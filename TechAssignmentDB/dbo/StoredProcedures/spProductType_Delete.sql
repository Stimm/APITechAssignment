CREATE PROCEDURE [dbo].[spProductType_Delete]
	@TypeID int
AS
begin
	DELETE
	from dbo.[ProductType]
	where TypeId = @TypeId
end