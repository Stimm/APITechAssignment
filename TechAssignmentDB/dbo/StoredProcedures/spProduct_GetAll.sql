CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
	SELECT ProductId, TypeId
	from dbo.[Product]
end
