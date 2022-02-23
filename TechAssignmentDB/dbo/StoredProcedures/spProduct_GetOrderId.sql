CREATE PROCEDURE [dbo].[spProduct_GetOrderId]
	@OrderId int
AS
begin
	SELECT ProductId, TypeId, OrderId
	from dbo.[Product]
	where OrderId = @OrderId;
end
