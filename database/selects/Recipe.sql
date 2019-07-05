USE [CookHubDB];

SELECT * FROM [dbo].[RecipeInfo]
LEFT JOIN [dbo].[Ingredient] ON [dbo].[RecipeInfo].[IngredientId] = [dbo].[Ingredient].[Id]
LEFT JOIN [dbo].[Recipe] ON [dbo].[RecipeInfo].[RecipeId] = [dbo].[Recipe].[Id]
LEFT JOIN [dbo].[Unit] ON [dbo].[RecipeInfo].[UnitId] = [dbo].[Unit].[Id]

