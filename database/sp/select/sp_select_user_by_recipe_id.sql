USE [CookHubDB]
GO
CREATE PROCEDURE [dbo].[sp_select_user_by_recipe_id]
	@recipeId INT
AS
BEGIN
	SELECT [User].*
	FROM [dbo].[Recipe]
	LEFT JOIN [dbo].[User] ON [User].[Id] = [Recipe].[UserId]
	WHERE [Recipe].[Id] = @RecipeId
END



