USE [CookHubDB]
GO
CREATE TYPE [dbo].[userImageTable] AS TABLE(
	[Id] INT,
	[UserId] INT,
	[Path] NVARCHAR(MAX)	
);