USE [CookHubDB];
CREATE TABLE [dbo].[IngredientRecipeDetails]
(
	[Id]INT IDENTITY NOT NULL,
	[RecipeId]INT NOT NULL,
	[IngredientId]INT NOT NULL,
	[DetailsId]INT NOT NULL,
	PRIMARY KEY CLUSTERED([Id]ASC),
	FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipe]([Id]),
	FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredient]([Id]),
	FOREIGN KEY ([DetailsId]) REFERENCES [dbo].[IngredientDetails]([Id])
);