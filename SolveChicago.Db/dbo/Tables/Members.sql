﻿CREATE TABLE [dbo].[Members]
(
	[Id] INT IDENTITY(1, 1) NOT NULL,
	[Email] NVARCHAR(128) NULL,
    [FirstName] NVARCHAR(128) NULL, 
    [MiddleName] NVARCHAR(128) NULL, 
    [LastName] NVARCHAR(128) NULL, 
    [Suffix] NVARCHAR(10) NULL, 
    [ProfilePicturePath] NVARCHAR(MAX) NULL, 
    [CreatedDate] DATETIME2 NULL, 
    [Gender] NVARCHAR(50) NULL, 
    [Birthday] DATETIME2 NULL, 
    [FamilyId] INT NULL, 
    [IsHeadOfHousehold] BIT NULL, 
    [Income] MONEY NULL, 
    [IsMilitary] BIT NULL, 
    [SurveyStep] NVARCHAR(50) NULL, 
    [ContactPreference] NVARCHAR(50) NULL, 
    [UserId] NVARCHAR(128) NULL, 
    [IsWorkforceInterested] BIT NULL, 
    [IsJobSearching] BIT NULL, 
    [SSN] VARCHAR(11) NULL, 
    [EthnicityId] INT NULL, 
    CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Member_Family] FOREIGN KEY (FamilyId) REFERENCES [Families]([Id]) ON DELETE SET NULL,
    CONSTRAINT [FK_Member_AspNetUser] FOREIGN KEY (UserId) REFERENCES [AspNetUsers](Id) ON DELETE SET NULL, 
    CONSTRAINT [FK_Member_Ethnicity] FOREIGN KEY (EthnicityId) REFERENCES [Ethnicities](Id) ON DELETE SET NULL, 
)
GO
EXEC sp_addextendedproperty N'MS_Description', N'Stores information about Members', 'SCHEMA', N'dbo', 'TABLE', N'Members', NULL, NULL
GO
EXEC sp_addextendedproperty N'MS_Description', N'i.e Phone or Email', 'SCHEMA', N'dbo', 'TABLE', N'Members', 'COLUMN', N'ContactPreference'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Controls whether they show up in Prospects', 'SCHEMA', N'dbo', 'TABLE', N'Members', 'COLUMN', N'IsWorkforceInterested'