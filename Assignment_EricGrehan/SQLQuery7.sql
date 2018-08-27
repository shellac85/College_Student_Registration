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