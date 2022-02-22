CREATE PROCEDURE [dbo].[spProductType_Insert]
	@TypeId varchar(60),
	@Description varchar(60),
	@Stock int
AS
begin
	INSERT INTO dbo.[ProductType](TypeId, Description, Stock)
	values (@TypeId, @Description, @Stock);
end
