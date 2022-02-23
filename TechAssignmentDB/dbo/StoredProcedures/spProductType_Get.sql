CREATE PROCEDURE [dbo].[spProductType_Get]
	@TypeID int
AS
begin
	SELECT TypeId, Description, Stock
	from dbo.[ProductType]
	where TypeId = @TypeId
end