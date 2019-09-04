USE [CookHubDB];
GO

CREATE PROCEDURE [dbo].[sp_insert_image]
(
    @Extension NVARCHAR(50),
    @Path NVARCHAR(MAX)
)
AS
BEGIN

Declare @sql nvarchar(max)
SET @sql = N'INSERT INTO [dbo].[Image]([Extension], [Data]) SELECT ' + @Extension + ' AS [Extension], * FROM OPENROWSET(BULK ' + CONVERT(NVARCHAR(MAX), @Path) + ', SINGLE_BLOB) AS [Data]'
EXEC (@sql)

END
GO