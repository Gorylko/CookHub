Use [CookHubDB];
GO
CREATE TYPE [dbo].[ingredientTable] AS TABLE (
    [Id] INT,
    [Amount] INT,
    [Unit] NVARCHAR(50)
);