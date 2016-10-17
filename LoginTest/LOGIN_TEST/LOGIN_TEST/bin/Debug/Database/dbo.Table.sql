CREATE TABLE [dbo].[LOGIN]
(
	[username] VARCHAR(50) NOT NULL , 
    [password] VARCHAR(50) NULL, 
    CONSTRAINT [PK_LOGIN] PRIMARY KEY ([username])
)
