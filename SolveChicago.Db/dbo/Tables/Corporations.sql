﻿CREATE TABLE [dbo].[Corporations]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [Email] NVARCHAR(128) NULL, 
    [Name] NVARCHAR(128) NULL,
    [CreatedDate] DATETIME2 NULL, 
    CONSTRAINT [PK_Corporations] PRIMARY KEY CLUSTERED ([Id] ASC), 
)
GO
EXEC sp_addextendedproperty N'MS_Description', N'Stores information about Corporations', 'SCHEMA', N'dbo', 'TABLE', N'Corporations', NULL, NULL
