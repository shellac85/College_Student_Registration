ALTER TRIGGER myTrigger
ON [dbo].[Student]

FOR INSERT,UPDATE, DELETE
AS
BEGIN
	DECLARE @EventData XML
	SELECT @EventData = EVENTDATA()

	INSERT INTO AdvancedProgrammingStudentDB.dbo.MyTable
	(DatabaseName, TableName, EventType, LoginName, SQLCommand, AuditDateTime) --columns for Table
	VALUES
	(
		@EventData.value('(/EVENT_INSTANCE/DatabaseName)[1]','varchar(250)'), --value function, vlaues from XML FILE
		@EventData.value('(/EVENT_INSTANCE/ObjectName)[1]','varchar(250)'),
		@EventData.value('(/EVENT_INSTANCE/EventType)[1]','varchar(250)'),
		@EventData.value('(/EVENT_INSTANCE/LoginName)[1]','varchar(250)'),
		@EventData.value('(/EVENT_INSTANCE/SQLCommand)[1]','varchar(2500)'),
		GETDATE()
	)
	END