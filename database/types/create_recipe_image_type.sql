USE [CookHubDB]
GO
CREATE TYPE [dbo].[recipeImageTable] AS TABLE(
	[Id] INT,
	[RecipeId] INT,
	[Path] NVARCHAR(MAX)	
);