USE [CookHubDB];

SELECT [dbo].[Ingredient].* FROM [dbo].[RecipeInfo]
LEFT JOIN [dbo].[Ingredient] ON [dbo].[RecipeInfo].[IngredientId] = [dbo].[Ingredient].[Id]
WHERE [RecipeId] = @id