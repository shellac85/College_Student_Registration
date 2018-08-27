CREATE PROC uspDeleteFromStudent
AS
BEGIN
    DELETE FROM Student
    WHERE FirstName = @firstname
END
GO