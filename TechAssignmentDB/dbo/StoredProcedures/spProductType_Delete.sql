CREATE PROCEDURE [dbo].[spProductType_Delete]
	@TypeID varchar(60)
AS
begin
	DELETE
	from dbo.[ProductType]
	where TypeId = @TypeId
end