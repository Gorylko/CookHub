USE [CookHubDB];
CREATE TABLE [dbo].[RecipeInfo]
(
	[Id]INT IDENTITY NOT NULL,
	[RecipeId]INT NOT NULL,
	[IngredientId]INT NOT NULL,
	[UnitId]INT NOT NULL,
	[Amount]INT NOT NULL,
	PRIMARY KEY CLUSTERED([Id]ASC),
	FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipe]([Id]),
	FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredient]([Id]),
	FOREIGN KEY ([UnitId]) REFERENCES [dbo].[Unit]([Id])
);