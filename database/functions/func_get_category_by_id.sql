USE [CookHubDB];
GO
CREATE FUNCTION [dbo].[func_get_category_by_id](@categoryId INT)
RETURNS NVARCHAR(50)
AS BEGIN
    DECLARE @category NVARCHAR(50)
    SELECT @category =[dbo].[Category].[Name]
    FROM [dbo].[Category]
    WHERE [dbo].[Category].[Id] = @categoryId
    RETURN @category
END