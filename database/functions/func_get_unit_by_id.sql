USE [CookHubDB];
GO
CREATE FUNCTION [dbo].[func_get_unit_by_id](@unitId INT)
RETURNS NVARCHAR(50)
AS BEGIN
    DECLARE @unit NVARCHAR(50)
    SELECT @unit =[dbo].[Unit].[Name]
    FROM [dbo].[Unit]
    WHERE [dbo].[Unit].[Id] = @unitId
    RETURN @unit
END