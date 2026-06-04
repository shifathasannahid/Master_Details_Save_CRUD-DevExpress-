namespace MasterDetailsSaveCRUD
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtCustomer = new System.Windows.Forms.TextBox();
            dateEdit1 = new System.Windows.Forms.DateTimePicker();
            gridControlMaster = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControlDetail = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControlMaster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            SuspendLayout();
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new System.Drawing.Point(30, 20);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new System.Drawing.Size(200, 21);
            txtCustomer.TabIndex = 0;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // dateEdit1
            // 
            dateEdit1.Location = new System.Drawing.Point(30, 60);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Size = new System.Drawing.Size(200, 21);
            dateEdit1.TabIndex = 1;
            // 
            // gridControlMaster
            // 
            gridControlMaster.Location = new System.Drawing.Point(30, 110);
            gridControlMaster.MainView = gridView1;
            gridControlMaster.Name = "gridControlMaster";
            gridControlMaster.Size = new System.Drawing.Size(350, 150);
            gridControlMaster.TabIndex = 2;
            gridControlMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControlMaster;
            gridView1.Name = "gridView1";
            // 
            // gridControlDetail
            // 
            gridControlDetail.Location = new System.Drawing.Point(420, 110);
            gridControlDetail.MainView = gridView2;
            gridControlDetail.Name = "gridControlDetail";
            gridControlDetail.Size = new System.Drawing.Size(350, 150);
            gridControlDetail.TabIndex = 3;
            gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.GridControl = gridControlDetail;
            gridView2.Name = "gridView2";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(30, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(100, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(150, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(100, 35);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(270, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(100, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(800, 400);
            Controls.Add(txtCustomer);
            Controls.Add(dateEdit1);
            Controls.Add(gridControlMaster);
            Controls.Add(gridControlDetail);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "Form1";
            Text = "Master Detail CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlMaster).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DateTimePicker dateEdit1;

        private DevExpress.XtraGrid.GridControl gridControlMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}