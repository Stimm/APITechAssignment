CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
	SELECT ProductId, TypeId, OrderId
	from dbo.[Product]
end
