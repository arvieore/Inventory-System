CREATE DATABASE InventoryDB;

use InventoryDB;

SELECT * FROM Accounts
SELECT * FROM [Role]
----------------------- Create Account --------------------------------
CREATE PROCEDURE sp_AddAccount
	@firstname varchar(50),
	@lastname varchar(50),
	@email varchar(50),
	@phone varchar(50),
	@gender varchar(10),
	@birthdate Date,
	@position varchar(50),
	@password varchar(50),
	@address varchar(250)
AS
BEGIN
	DECLARE @roleIndex INT
	DECLARE @username varchar(50)

	SELECT @roleIndex = roleID
	FROM [Role]
	WHERE roleName = @position

	SET @username = CONCAT(@firstname, @lastname, YEAR(@birthdate))

	INSERT INTO Accounts (user_firstname, user_lastname, user_email, user_phone, user_gender, user_birthdate, user_position, user_name, user_password, user_Address, roleID)
	VALUES (@firstname, @lastname, @email, @phone, @gender, @birthdate, @position, @username, @password, @address, @roleIndex)
END
----------------------- Check Position of the account --------------------------------
CREATE PROCEDURE sp_ValidateAccount
	@user_name varchar(50),
	@user_password varchar(50)
AS
BEGIN
	SELECT user_ID, user_Position
	FROM Accounts
	WHERE user_name = @user_name AND user_password = @user_password;
END
----------------------- Add Product --------------------------------
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


SELECT * FROM Products