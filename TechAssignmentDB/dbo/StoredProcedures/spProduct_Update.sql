CREATE PROCEDURE [dbo].[spProduct_Update]
	@ProductId varchar(60),
	@TypeId int,
	@OrderId int
AS
begin
	UPDATE dbo.[Product]
	set OrderId = @OrderId,TypeId= @TypeId
	WHERE ProductId = @ProductId
end