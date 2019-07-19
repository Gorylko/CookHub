USE [CookHubDB];
CREATE TABLE [dbo].[Recipe]
(
	[Id]INT IDENTITY NOT NULL,
	[Name]NVARCHAR(100) NOT NULL,
	[Description]NVARCHAR(MAX),
	[CategoryId]INT NOT NULL,
	[UserId]INT NOT NULL,
	PRIMARY KEY CLUSTERED([Id] ASC),
	FOREIGN KEY([UserId]) REFERENCES [dbo].[User]([Id]),
	FOREIGN KEY([CategoryId]) REFERENCES [dbo].[Category]([Id])
);