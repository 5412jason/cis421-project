USE PlayItAgainSports
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        Tristan Wojtas
-- Create date: 12/10/2020
-- Description:    Add Item
-- =============================================
CREATE PROCEDURE dbo.AddItem
    @ItemCount INT,
    @Price INT,
    @ItemName NVARCHAR(50)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    INSERT INTO dbo.Item(ItemCount,Price,ItemName)
    VALUES (@ItemCount,@Price,@ItemName) 
END
GO