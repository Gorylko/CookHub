USE [CookHubDB]
GO
CREATE PROCEDURE [dbo].[sp_select_user_by_recipe_id]
	@recipeId INT
AS
BEGIN
	DECLARE @user TABLE (
		[Id]INT,
		[Login]NVARCHAR(50),
		[Email]NVARCHAR(50),
		[PhoneNumber]NVARCHAR(20),
		[RoleId]INT
	);
	INSERT INTO @user
	SELECT 
	[User].*
	FROM [dbo].[Recipe]
	INNER JOIN [dbo].[User] ON [User].[Id] = [Recipe].[UserId]
	WHERE [Recipe].[Id] = @RecipeId

	SELECT * FROM @user

	SELECT
		[UserImage].*
	FROM @user AS [user]
	INNER JOIN [dbo].[UserImage] ON [user].[Id] = [UserImage].[UserId]
END



