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

CREATE PROCEDURE sp_AddNewProduct
	@CategoryName varchar(50),
	@productName varchar(50),
	@product_sku varchar(50),
	@product_quantity varchar(50),
	@product_price decimal(10, 2),
	@product_description varchar(50)
AS
BEGIN
	DECLARE @CategoryID INT
	-- Check if the category already exists
	IF EXISTS (SELECT 1 FROM Category WHERE categoryName = @CategoryName)
	BEGIN
		-- Category already exists, retrieve the existing CategoryID
		SELECT @CategoryID = categoryID FROM Category WHERE categoryName = @CategoryName
	END

	ELSE
	BEGIN
		-- Category does not exist, insert a new category
		INSERT INTO Category (categoryName) VALUES (@CategoryName)
		SELECT @CategoryID = SCOPE_IDENTITY();
	END

	DECLARE @ProductID INT
	-- Insert the product with the obtained or newly inserted CategoryID
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

----------------------- CATEGORY FILTER --------------------------------
Create Procedure sp_CategoryFilter 
	@CategoryFiltered varchar(50)
AS
BEGIN
	IF @CategoryFiltered = 'All'
	BEGIN
		SELECT p.productID, p.product_Name, p.product_Sku, p.product_Quantity, p.product_Price, p.product_Description, c.categoryName
		FROM Products p JOIN Category c
		on p.categoryID = c.categoryID;
	END
	ELSE
	BEGIN
		SELECT p.productID, p.product_Name, p.product_Sku, p.product_Quantity, p.product_Price, p.product_Description, c.categoryName
		FROM Products p 
		JOIN Category c 
		on p.categoryID = c.categoryID 
		WHERE c.categoryName = @CategoryFiltered;
	END
END