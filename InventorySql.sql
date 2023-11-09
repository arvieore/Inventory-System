CREATE DATABASE InventoryDB;

use InventoryDB;

INSERT INTO Accounts (user_name, user_password, user_Position, user_Address) 
VALUES ('arvieAdmin', 'password', 'Admin', 'LLC');

CREATE PROCEDURE sp_ValidateAccount
	@user_name varchar(50),
	@user_password varchar(50)
AS
BEGIN
	SELECT user_ID, user_Position
	FROM Accounts
	WHERE user_name = @user_name AND user_password = @user_password;
END

--EXEC sp_ValidateAccount @user_name = 'arvieAdmin', @user_password = 'password'

Create Procedure sp_AddNewProduct
	@CategoryName varchar(50),
	@productName varchar(50),
	@product_sku varchar(50),
	@product_quantity varchar(50),
	@product_price decimal(10, 2),
	@product_description varchar(50)
AS
BEGIN
	DECLARE @CategoryID INT
	
	INSERT INTO Category (categoryName) VALUES (@CategoryName)
	SELECT @CategoryID = SCOPE_IDENTITY();

	DECLARE @ProductID INT

	INSERT INTO Products
	(
		product_Name, 
		product_Sku, 
		product_Quantity, 
		product_Price, 
		product_Description,
		categoryID
	)
	VALUES 
	(
		@productName, 
		@product_sku, 
		@product_quantity, 
		@product_price, 
		@product_description,
		@categoryID
	)
	SELECT @ProductID = SCOPE_IDENTITY();
END

SELECT * FROM Category
SELECT * FROM Products