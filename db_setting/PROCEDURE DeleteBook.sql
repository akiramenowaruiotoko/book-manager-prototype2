USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[DeleteBook]
    @TargetBookId VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在するか確認
    IF EXISTS (SELECT 1 FROM books WHERE book_id = @TargetBookId)
		BEGIN
			-- 存在する場合は削除
			DELETE FROM books WHERE book_id = @TargetBookId;
			RETURN 0; -- 削除成功
		END
    ELSE
		BEGIN
			-- 存在しない場合は削除中止
			RETURN -1; -- 削除対象が存在しない
		END
END;
