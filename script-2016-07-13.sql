if exists (select * from sysobjects where id = OBJECT_ID('[User]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [User]

CREATE TABLE [User] (
[UserId] [int]  IDENTITY (1, 1)  NOT NULL,
[Username] [nvarchar]  (256) NOT NULL,
[PasswordHash] [nvarchar]  (500) NULL,
[Email] [nvarchar]  (256) NULL,
[PhoneNumber] [nvarchar]  (30) NULL,
[IsFirstTimeLogin] [bit]  NOT NULL DEFAULT (1),
[AccessFailedCount] [int]  NOT NULL DEFAULT (0),
[CreationDate] [datetime]  NOT NULL DEFAULT (getdate()),
[IsActive] [bit]  NOT NULL DEFAULT (1),
[LastTimestamp] [timestamp]  NULL)

ALTER TABLE [User] WITH NOCHECK ADD  CONSTRAINT [PK_User] PRIMARY KEY  NONCLUSTERED ( [UserId] )
SET IDENTITY_INSERT [User] ON
SET IDENTITY_INSERT [User] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[Person]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [Person]

CREATE TABLE [Person] (
[id] [int]  IDENTITY (1, 1)  NOT NULL,
[username] [nvarchar]  (100) NULL,
[password] [nvarchar]  (100) NULL,
[age] [int]  NULL,
[registerDate] [datetime]  NULL,
[address] [nvarchar]  (150) NULL)

ALTER TABLE [Person] WITH NOCHECK ADD  CONSTRAINT [PK_Person] PRIMARY KEY  NONCLUSTERED ( [id] )
SET IDENTITY_INSERT [Person] ON
SET IDENTITY_INSERT [Person] OFF
