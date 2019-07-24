USE [CookHubDB]
GO
CREATE PROCEDURE [dbo].[sp_select_user_by_id]
	@userId INT
AS
BEGIN
	SELECT *
	FROM [dbo].[User]
	WHERE [User].[Id] = @userId
END



