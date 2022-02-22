CREATE PROCEDURE [dbo].[spOrder_Get]
	@OrderId int
AS
begin
	SELECT OrderId, ProductId, TypeId, Description
	from dbo.[Order]
	WHERE OrderId = @OrderId;
end
