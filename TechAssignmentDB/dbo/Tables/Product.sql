CREATE TABLE [dbo].[Product]
(
	[ProductID] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TypeID]VARCHAR(50) NOT NULL,
    CONSTRAINT [FK_Product_ProductType] FOREIGN KEY (TypeID) REFERENCES ProductType(TypeID)
)
