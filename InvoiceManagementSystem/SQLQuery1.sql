--Step-1

--CREATE DATABASE InvoiceDBMaster;
--GO
--USE InvoiceDBMaster;

--Detail Table (InvoiceDetails)

--Master Table (Invoice)

--CREATE TABLE Invoice
--(
--    InvoiceId INT IDENTITY(1,1) PRIMARY KEY,
--    CustomerName NVARCHAR(100),
--    InvoiceDate DATE
--);


--Detail Table (InvoiceDetails)

--CREATE TABLE InvoiceDetails
--(
--    DetailId INT IDENTITY(1,1) PRIMARY KEY,
--    InvoiceId INT FOREIGN KEY REFERENCES Invoice(InvoiceId),
--    ProductName NVARCHAR(100),
--    Qty INT,
--    Price DECIMAL(18,2)
--);

--2. Stored Procedures Insert Master

--CREATE PROCEDURE sp_Invoice_Insert
--@CustomerName NVARCHAR(100),
--@InvoiceDate DATE
--AS
--BEGIN
--    INSERT INTO Invoice(CustomerName, InvoiceDate)
--    VALUES(@CustomerName, @InvoiceDate);

--    SELECT SCOPE_IDENTITY();
--END

--Insert Detail Store procedure


--CREATE PROCEDURE sp_InvoiceDetail_Insert
--@InvoiceId INT,
--@ProductName NVARCHAR(100),
--@Qty INT,
--@Price DECIMAL(18,2)
--AS
--BEGIN
--    INSERT INTO InvoiceDetails(InvoiceId, ProductName, Qty, Price)
--    VALUES(@InvoiceId, @ProductName, @Qty, @Price);
--END

--Load Master Store procedure

--CREATE PROCEDURE sp_Invoice_GetAll
--AS
--BEGIN
--    SELECT * FROM Invoice;
--END

--Delete Store procedure
 
--CREATE PROCEDURE sp_Invoice_Delete
--@InvoiceId INT
--AS
--BEGIN
--    DELETE FROM InvoiceDetails WHERE InvoiceId=@InvoiceId;
--    DELETE FROM Invoice WHERE InvoiceId=@InvoiceId;
--END

