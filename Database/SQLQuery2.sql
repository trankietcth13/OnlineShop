USE [OnlineShop]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[GetAccount]

SELECT	'Return Value' = @return_value

GO
