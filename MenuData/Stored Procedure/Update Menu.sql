CREATE PROCEDURE [dbo].[Update Menu]
	  @Id INT,
    @Code NVARCHAR(50),
    @Name NVARCHAR(100),
    @Category NVARCHAR(100),
    @Price DECIMAL(10,2)
AS
BEGIN
    UPDATE Menus
    SET Code = @Code,
        Name = @Name,
        Category = @Category,
        Price = @Price
    WHERE Id = @Id
END
