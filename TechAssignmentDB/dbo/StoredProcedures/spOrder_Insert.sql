CREATE PROCEDURE [dbo].[spOrder_Insert]
	@Address varchar(60)
AS
begin
	INSERT INTO dbo.[Order](Address)
	values (@Address)
end
