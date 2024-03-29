USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[DeleteEmployee]
    @TargetEmployeeNumber INT
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在するか確認
    IF EXISTS (SELECT 1 FROM employees WHERE employee_number = @TargetEmployeeNumber)
		BEGIN
			-- 存在する場合は削除
			DELETE FROM employees WHERE employee_number = @TargetEmployeeNumber;
			RETURN 0; -- 削除成功
		END
    ELSE
		BEGIN
			-- 存在しない場合は削除中止
			RETURN -1; -- 削除対象が存在しない
		END
END;
