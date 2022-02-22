CREATE PROCEDURE [dbo].[spProduct_Insert]
	@ProductId varchar(60),
	@TypeId varchar(60)
AS
begin
	INSERT INTO dbo.[Product](ProductId, TypeId)
	values (@ProductId, @TypeId);
end
