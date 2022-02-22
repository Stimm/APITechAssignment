CREATE PROCEDURE [dbo].[spOrder_Insert]
	@ProductId varchar(60),
	@TypeId varchar(60),
	@Description varchar(60)
AS
begin
	INSERT INTO dbo.[Order](ProductId, TypeId, Description)
	values (@ProductId, @TypeId, @Description)
end
