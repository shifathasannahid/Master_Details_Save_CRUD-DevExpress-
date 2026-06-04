using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MasterDetailsSaveCRUD
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        string conStr =
            @"Data Source=DESKTOP-5BNTOH9\SQLEXPRESS;Initial Catalog=InvoiceDBMaster;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        int selectedInvoiceId = 0;

        public Form1()
        {
            InitializeComponent();

            btnSave.Click += btnSave_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;

            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
        }

        // ================= FORM LOAD =================
        private void Form1_Load(object sender, EventArgs e)
        {
            txtCustomer.Text = "";
            LoadMaster();

            SetupDetailGrid();
        }

        // ================= DETAIL GRID SETUP =================
        private void SetupDetailGrid()
        {
            gridView2.Columns.Clear();

            gridView2.Columns.AddVisible("ProductName", "Product Name");
            gridView2.Columns.AddVisible("Qty", "Qty");
            gridView2.Columns.AddVisible("Price", "Price");

            gridView2.OptionsBehavior.Editable = true;

            gridView2.OptionsView.NewItemRowPosition =
                DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            // IMPORTANT FIX
            gridView2.GridControl = gridControlDetail;
        }

        // ================= MASTER LOAD =================
        private void LoadMaster()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("sp_Invoice_GetAll", conStr))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                gridControlMaster.DataSource = dt;
            }
        }

        // ================= LOAD DETAILS =================
        private void LoadDetails(int invoiceId)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("sp_InvoiceDetail_ByInvoice", conStr))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@InvoiceId", invoiceId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // 🔥 FIX (THIS WAS YOUR MAIN BUG)
                gridControlDetail.DataSource = dt;
            }
        }

        // ================= SAVE =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_Invoice_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerName", txtCustomer.Text);
                cmd.Parameters.AddWithValue("@InvoiceDate", dateEdit1.Value);

                int invoiceId = Convert.ToInt32(cmd.ExecuteScalar());

                SaveDetails(con, invoiceId);

                MessageBox.Show("Saved Successfully");

                LoadMaster();
            }
        }

        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedInvoiceId == 0)
            {
                MessageBox.Show("Select invoice first");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_Invoice_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@InvoiceId", selectedInvoiceId);
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomer.Text);
                cmd.Parameters.AddWithValue("@InvoiceDate", dateEdit1.Value);

                cmd.ExecuteNonQuery();

                SqlCommand del = new SqlCommand(
                    "DELETE FROM InvoiceDetails WHERE InvoiceId=@id", con);

                del.Parameters.AddWithValue("@id", selectedInvoiceId);
                del.ExecuteNonQuery();

                SaveDetails(con, selectedInvoiceId);

                MessageBox.Show("Updated Successfully");

                LoadMaster();
            }
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedInvoiceId == 0)
            {
                MessageBox.Show("Select invoice first");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                // 🔥 STEP 1: delete details first
                SqlCommand cmd1 = new SqlCommand(
                    "DELETE FROM InvoiceDetails WHERE InvoiceId=@id", con);
                cmd1.Parameters.AddWithValue("@id", selectedInvoiceId);
                cmd1.ExecuteNonQuery();

                // 🔥 STEP 2: delete master
                SqlCommand cmd2 = new SqlCommand(
                    "DELETE FROM Invoice WHERE InvoiceId=@id", con);
                cmd2.Parameters.AddWithValue("@id", selectedInvoiceId);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully");

                LoadMaster();
                ClearForm();
            }
        }
        // ================= MASTER CLICK =================
        private void gridView1_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount <= 0) return;

            object id = gridView1.GetFocusedRowCellValue("InvoiceId");

            if (id == null) return;

            selectedInvoiceId = Convert.ToInt32(id);

            txtCustomer.Text =
                gridView1.GetFocusedRowCellValue("CustomerName")?.ToString();

            dateEdit1.Value =
                Convert.ToDateTime(gridView1.GetFocusedRowCellValue("InvoiceDate"));

            LoadDetails(selectedInvoiceId);
        }

        // ================= SAVE DETAILS =================
        private void SaveDetails(SqlConnection con, int invoiceId)
        {
            for (int i = 0; i < gridView2.DataRowCount; i++)
            {
                object product = gridView2.GetRowCellValue(i, "ProductName");

                if (product == null || product.ToString() == "")
                    continue;

                SqlCommand cmd = new SqlCommand("sp_InvoiceDetail_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);
                cmd.Parameters.AddWithValue("@ProductName", product.ToString());
                cmd.Parameters.AddWithValue("@Qty",
                    Convert.ToInt32(gridView2.GetRowCellValue(i, "Qty")));
                cmd.Parameters.AddWithValue("@Price",
                    Convert.ToDecimal(gridView2.GetRowCellValue(i, "Price")));

                cmd.ExecuteNonQuery();
            }
        }

        // ================= CLEAR =================
        private void ClearForm()
        {
            txtCustomer.Text = "";
            selectedInvoiceId = 0;
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}