CREATE PROCEDURE [dbo].[spProductType_Update]
	@OrderId int,
	@ProductId varchar(60),
	@TypeId varchar(60),
	@Description varchar(60)
AS
begin
	UPDATE dbo.[Order]
	set ProductId = @ProductId, TypeId = @TypeId, Description = @Description
	WHERE OrderId = @OrderId
end
