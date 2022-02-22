CREATE PROCEDURE [dbo].[spOrder_GetAll]
AS
begin
	SELECT OrderId, ProductId, TypeId, Description
	from dbo.[Order];
end
