CREATE PROCEDURE [dbo].[Create Menu]
	 @Code NVARCHAR(50),
    @Name NVARCHAR(100),
    @Category NVARCHAR(100),
    @Price DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Menus(Code, Name, Category, Price)
    VALUES(@Code, @Name, @Category, @Price)
END
