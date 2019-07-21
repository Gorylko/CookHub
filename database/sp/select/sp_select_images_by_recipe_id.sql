USE [CookHubDB]
GO
CREATE PROCEDURE [dbo].[sp_select_images_by_recipe_id]
	@recipeId INT
AS
BEGIN
	SELECT *
    FROM [dbo].[RecipeImage]
    WHERE [RecipeId] = @recipeId
END