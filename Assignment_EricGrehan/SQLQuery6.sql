﻿CREATE TRIGGER tr_AuditTableChanges
ON ALL SERVER													
FOR CREATE_TABLE, ALTER_TABLE, DROP_TABLE
AS
BEGIN
	SELECT EVENTDATA()
END