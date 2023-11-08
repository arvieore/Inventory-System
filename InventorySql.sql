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