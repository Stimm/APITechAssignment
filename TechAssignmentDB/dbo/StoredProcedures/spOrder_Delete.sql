CREATE PROCEDURE [dbo].[spOrder_Delete]
	@OrderId varchar(60)
AS
begin
	DELETE
	from dbo.[Order]
	WHERE OrderId = @OrderId;
end
