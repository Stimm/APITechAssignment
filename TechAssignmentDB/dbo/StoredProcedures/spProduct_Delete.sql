CREATE PROCEDURE [dbo].[spProduct_Delete]
	@ProductId varchar(60)
AS
begin
	DELETE
	from dbo.[Product]
	where ProductId = @ProductId;
end
