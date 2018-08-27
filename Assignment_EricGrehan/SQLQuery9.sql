CREATE TRIGGER tr_AuditTableChanges
ON dbo.Student													
AFTER INSERT,UPDATE,DELETE
AS
BEGIN
	SELECT EVENTDATA()
END


CREATE TABLE TableChanges
(
	StudentFirstName nvarchar(250),
	StudentLastName nvarchar(250),
	TableName nvarchar (250),
	EventType nvarchar(250),
	LoginName nvarchar(250),
	SQLCommand nvarchar (2500),
	AuditDateTime datetime
)
GO



ALTER TRIGGER tr_AuditTableChanges
ON dbo.Student		
after INSERT,UPDATE,DELETE
AS
BEGIN
	DECLARE @EventData XML
	SELECT @EventData = EVENTDATA()

	INSERT INTO AdvancedProgrammingStudentDB.dbo.TableChanges
	(StudentFirstName, StudentLastName, TableName, EventType, LoginName, SQLCommand, AuditDateTime) --columns for Table
	VALUES
	(
		@EventData.value('(/EVENT_INSTANCE/StudentFirstName)[1]','varchar(250)'), --value function, vlaues from XML FILE
		@EventData.value('(/EVENT_INSTANCE/StudentLastName)[1]','varchar(250)'),
		@EventData.value('(/EVENT_INSTANCE/TableName)[1]','varchar(250)'),
		@EventData.value('(/EVENT_INSTANCE/EventType)[1]','varchar(250)'),
		@EventData.value('(/EVENT_INSTANCE/LoginName)[1]','varchar(250)'),
		@EventData.value('(/EVENT_INSTANCE/SQLCommand)[1]','varchar(2500)'),
		
		GETDATE()
	)
	END



