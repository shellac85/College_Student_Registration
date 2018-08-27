alter TRIGGER tr_AuditTableChangesDeleted
ON Student													
FOR delete
AS
BEGIN
	--select * from inserted
	declare @Id int

	select @Id = StudentId from deleted

	insert into AuditStudentTableDeleted
	values('New Student with Id = ' + CAST(@Id as nvarchar(8)) + ' was deleted at ' + cast (GETDATE() as nvarchar(20))
	)
END