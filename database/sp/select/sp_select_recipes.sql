USE [CookHubDB];
GO

CREATE PROCEDURE [dbo].[sp_select_recipes]
AS
BEGIN
	SELECT
		[Recipe].[Id],
		[Recipe].[Name],
		[Recipe].[Description],
		[RecipeImage].[Path]
	FROM [dbo].[Recipe]
	INNER JOIN [RecipeImage]
	ON [RecipeImage].[Id] =
	 (
		SELECT TOP 1 [RecipeImage].[Id]
		FROM [RecipeImage]
		WHERE [RecipeImage].[RecipeId] = [Recipe].[Id]
	)
END