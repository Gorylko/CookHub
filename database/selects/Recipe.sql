USE [CookHubDB];

SELECT [Recipe].*, [RecipeImage].[Path] FROM [dbo].[Recipe]
LEFT JOIN [dbo].[RecipeImage] ON [dbo].[Recipe].[Id] = [dbo].[RecipeImage].[RecipeId]