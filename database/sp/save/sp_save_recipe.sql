USE [CookHubDB]
GO
CREATE PROCEDURE [dbo].[sp_save_recipe]
	@RecipeId INT,
	@Name NVARCHAR(100),
	@Description NVARCHAR(MAX),
	@CategoryId INT,
	@UserId INT,
	@Ingredients [dbo].ingredientTabe NULL,
	@Images [dbo]