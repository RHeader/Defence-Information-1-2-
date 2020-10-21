CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Login] NVARCHAR(MAX) NOT NULL, 
    [Password] NVARCHAR(MAX) NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL
)
