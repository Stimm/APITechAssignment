CREATE PROCEDURE [dbo].[spProduct_Get]
	@ProductId varchar(60)
AS
begin
	SELECT ProductId, TypeId
	from dbo.[Product]
	where ProductId = @ProductId;
end
