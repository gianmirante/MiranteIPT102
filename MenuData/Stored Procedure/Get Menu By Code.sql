CREATE PROCEDURE [dbo].[Get Menu By Code]
	 @Code NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Menus WHERE Code = @Code
END