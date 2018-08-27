CREATE TRIGGER tr_AuditTableChanges
ON ALL SERVER													
FOR CREATE_TABLE, ALTER_TABLE, DROP_TABLE
AS
BEGIN
	SELECT EVENTDATA()
END
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
CREATE TABLE TableChanges
(
	DatabaseName nvarchar(250),
	TableName nvarchar (250),
	EventType nvarchar(250),
	LoginName nvarchar(250),
	SQLCommand nvarchar (2500),
	AuditDateTime datetime
)
GO

Select * FROM TableChanges

Create Table MyTable(Id int, Nme nvarchar(50))

Alter Table MyTable
Alter Column Nme nvarchar(100)

DROP Table MyTable
///////////////////////////////////////////////////////////////////
ALTER TRIGGER tr_AuditTableChanges
ON ALL SERVER

FOR CREATE_TABLE, ALTER_TABLE, DROP_TABLE
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