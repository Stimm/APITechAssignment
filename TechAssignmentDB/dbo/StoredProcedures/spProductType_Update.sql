CREATE PROCEDURE [dbo].[spProductType_Update]
	@TypeId int,
	@Description varchar(60),
	@Stock int
AS
begin
	UPDATE dbo.[ProductType]
	set Description = @Description, Stock = @Stock
	WHERE TypeId = @TypeId
end
