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
		[Recipe].[UserId],
		[dbo].func_get_category_by_id([Recipe].[CategoryId]) AS [Category]

	FROM [dbo].[Recipe]
    WHERE [Recipe].[Id] = @recipeId

	EXEC [dbo].[sp_select_ingredients_by_recipe_id] @recipeId
	EXEC [dbo].[sp_select_images_by_recipe_id] @recipeId
	EXEC [dbo].[sp_select_user_by_recipe_id] @recipeId
END



