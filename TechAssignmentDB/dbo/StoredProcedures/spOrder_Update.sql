CREATE PROCEDURE [dbo].[spOrder_Update]
	@OrderId int,
	@Address  varchar(60)
AS
begin
	UPDATE dbo.[Order]
	set Address = @Address 
	WHERE OrderId = @OrderId
end
