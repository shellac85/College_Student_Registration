CREATE TABLE [dbo].[Student]
(
	[StudentId] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NULL, 
    [SurName] VARCHAR(50) NULL, 
    [AddressLine1 ] VARBINARY(50) NULL, 
    [AddressLine2 ] VARCHAR(50) NULL, 
    [County ] VARCHAR(50) NULL, 
    [Course] VARCHAR(50) NULL, 
    [Level] VARCHAR(50) NULL
)
