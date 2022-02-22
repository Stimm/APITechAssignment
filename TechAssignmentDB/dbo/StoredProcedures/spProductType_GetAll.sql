CREATE PROCEDURE [dbo].[spProductType_GetAll]
AS
begin
	SELECT TypeId, Description, Stock
	from dbo.[ProductType];
end