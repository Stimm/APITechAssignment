CREATE PROCEDURE [dbo].[spProduct_Insert]
	@ProductId varchar(60),
	@TypeId int
AS
begin
	INSERT INTO dbo.[Product](ProductId, TypeId)
	values (@ProductId, @TypeId);
end
