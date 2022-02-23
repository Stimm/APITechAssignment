CREATE PROCEDURE [dbo].[spOrder_Get]
	@OrderId int
AS
begin
	SELECT OrderId, Address
	from dbo.[Order]
	WHERE OrderId = @OrderId;
end
