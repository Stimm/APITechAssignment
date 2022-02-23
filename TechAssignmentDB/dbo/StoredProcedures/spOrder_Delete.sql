CREATE PROCEDURE [dbo].[spOrder_Delete]
	@OrderId int
AS
begin
	DELETE
	from dbo.[Order]
	WHERE OrderId = @OrderId;
end
