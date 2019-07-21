USE [CookHubDB]
GO
CREATE PROCEDURE [dbo].[sp_select_ingredients_by_recipe_id]
	@recipeId INT
AS
BEGIN
	SELECT
	[Ingredient].*,
	[RecipeInfo].[Amount] AS [Amount],
	[dbo].func_get_unit_by_id([RecipeInfo].[UnitId]) AS [Unit],
	[RecipeInfo].[RecipeId] AS [RecipeId]

    FROM [dbo].[RecipeInfo]
    LEFT JOIN [dbo].[Ingredient] ON[dbo].[RecipeInfo].[IngredientId] = [dbo].[Ingredient].[Id]
    WHERE [RecipeId] = @recipeId
END