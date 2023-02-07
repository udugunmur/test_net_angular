IF OBJECT_ID('[dbo].[DeviceLogical]') IS NOT NULL DROP TABLE [dbo].[DeviceLogical] 
IF OBJECT_ID('[dbo].[Project]') IS NOT NULL DROP TABLE [dbo].[Project]


CREATE TABLE [dbo].[Project](
	--PK:
	[ProjectId] int IDENTITY(1,1),
	--Data:
	[ProjectCode] nvarchar(50) NOT NULL,
	[ProjectName] nvarchar(100) NOT NULL,
	[CountryId] int NULL,
	[StateId] int NULL,
	[TechId] int NOT NULL,
	[Disabled] bit DEFAULT 0 NOT NULL,
	--Audit:
	[UpdateDate] datetime DEFAULT GETUTCDATE() NOT NULL, 
	[UpdateUserId] int DEFAULT 0 NOT NULL,
	[UpdateUserName] nvarchar(100) DEFAULT 'dba' NOT NULL,
	--Constraints:
	CONSTRAINT [PK_dbo_Project] PRIMARY KEY ([ProjectId]),
	CONSTRAINT [UK_dbo_Project_ProjectCode] UNIQUE ([ProjectCode]),
	CONSTRAINT [UK_dbo_Project_ProjectName] UNIQUE ([ProjectName]),
	CONSTRAINT [FK_dbo_Project_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [master].[Country]([CountryId]),
	CONSTRAINT [FK_dbo_Project_StateId] FOREIGN KEY ([StateId]) REFERENCES [master].[State]([StateId]),
	CONSTRAINT [FK_dbo_Project_TechId] FOREIGN KEY ([TechId]) REFERENCES [master].[Tech]([TechId])
)
GO


CREATE TABLE [dbo].[DeviceLogical](
	--PK:
	[DeviceLogicalId] int IDENTITY(1,1),
	--FK:
	[DeviceTypeId] int NOT NULL,	
	[ParentId] int NULL,
	[ProjectId] int NOT NULL,
	--Data:
	[DeviceLogicalName] nvarchar(100) NOT NULL,
	[AssetCode] varchar(100) NULL,
	[Disabled] bit DEFAULT 0 NOT NULL,
	--Audit:
	[UpdateDate] datetime DEFAULT GETUTCDATE() NOT NULL, 
	[UpdateUserId] int DEFAULT 0 NOT NULL,
	[UpdateUserName] nvarchar(100) DEFAULT 'dba' NOT NULL,
	--Constraints:
	CONSTRAINT [PK_dbo_DeviceLogical] PRIMARY KEY ([DeviceLogicalId]),
	CONSTRAINT [FK_dbo_DeviceLogical_ParentId] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[DeviceLogical]([DeviceLogicalId]),
	CONSTRAINT [FK_dbo_DeviceLogical_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project]([ProjectId]),
	CONSTRAINT [FK_dbo_DeviceLogical_DeviceTypeId] FOREIGN KEY ([DeviceTypeId]) REFERENCES [master].[DeviceType]([DeviceTypeId])
)
GO

INSERT INTO [dbo].[Project] ([ProjectCode],[ProjectName],[CountryId],[StateId],[TechId]) VALUES
	('PROJ-A','Project A',209,327,2),
	('PROJ-B','Project B',236,424,1)