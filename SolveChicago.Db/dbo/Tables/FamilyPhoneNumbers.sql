﻿CREATE TABLE [dbo].[FamilyPhoneNumbers]
(
	[FamilyId] INT NOT NULL,
    [PhoneNumberId] INT NOT NULL,
	
    PRIMARY KEY ([FamilyId], [PhoneNumberId]), 
    CONSTRAINT [FK_FamilyPhoneNumbers_Family] FOREIGN KEY ([FamilyId]) REFERENCES [Families]([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_FamilyPhoneNumbers_PhoneNumber] FOREIGN KEY (PhoneNumberId) REFERENCES [PhoneNumbers]([Id]) ON DELETE CASCADE,
)
