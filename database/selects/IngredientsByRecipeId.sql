USE [CookHubDB];
SELECT [dbo].[Ingredient].*, [dbo].[Unit].[Name] AS [Unit] FROM [dbo].[RecipeInfo]
LEFT JOIN [dbo].[Ingredient] ON [dbo].[RecipeInfo].[IngredientId] = [dbo].[Ingredient].[Id]
LEFT JOIN [dbo].[Unit] ON [dbo].[RecipeInfo].[UnitId] = [dbo].[Unit].[Id]
WHERE [RecipeId] = 3
