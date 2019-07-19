USE [CookHubDB]
GO
CREATE PROCEDURE [dbo].[sp_select_recipe_by_id]
	@recipeId INT
AS
BEGIN
	SELECT 
		[Recipe].[Id],
		[Recipe].[Name],
		[Recipe].[Description],
		[dbo].func_get_category_by_id([Recipe].[CategoryId]) AS [Category],
		[RecipeImage].[Path]
	
	FROM [dbo].[Recipe]
    LEFT JOIN[dbo].[RecipeImage] ON[dbo].[Recipe].[Id] = [dbo].[RecipeImage].[RecipeId]
    WHERE [Recipe].[Id] = @recipeId
END



