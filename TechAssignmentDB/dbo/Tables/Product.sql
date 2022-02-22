CREATE TABLE [dbo].[Product]
(
	[ProductId] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TypeId]VARCHAR(50) NOT NULL,
    CONSTRAINT [FK_Product_ProductType] FOREIGN KEY ([TypeId]) REFERENCES ProductType([TypeId])
)
