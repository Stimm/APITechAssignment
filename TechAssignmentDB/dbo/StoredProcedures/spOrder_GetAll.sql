CREATE PROCEDURE [dbo].[spOrder_GetAll]
AS
begin
	SELECT OrderId, Address
	from dbo.[Order];
end
