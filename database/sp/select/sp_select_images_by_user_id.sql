USE [CookHubDB];
GO
CREATE PROCEDURE [dbo].[sp_select_images_by_user_id]
	@userId INT
AS
BEGIN
	SELECT * 
	FROM [dbo].[UserImage]
	WHERE [UserId] = @userId
END