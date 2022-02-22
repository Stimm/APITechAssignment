CREATE PROCEDURE [dbo].[spProductType_Get]
	@TypeID varchar(60)
AS
begin
	SELECT TypeId, Description, Stock
	from dbo.[ProductType]
	where TypeId = @TypeId
end