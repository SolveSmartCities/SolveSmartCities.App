﻿CREATE TABLE [dbo].[SurveyAnswers]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [SurveyId] INT NOT NULL, 
    [QuestionId] INT NOT NULL, 
    [Answer] NVARCHAR(MAX) NOT NULL, 
    [AnswerBatchId] NVARCHAR(36) NOT NULL, 
    [UserId] INT NOT NULL,

	CONSTRAINT [PK_SurveyAnswers] PRIMARY KEY CLUSTERED ([AnswerBatchId] ASC),
    CONSTRAINT [FK_SurveyAnswers_Surveys] FOREIGN KEY (SurveyId) REFERENCES [Surveys](Id) ON DELETE NO ACTION, 
    CONSTRAINT [FK_SurveyAnswers_SurveyQuestions] FOREIGN KEY (QuestionId) REFERENCES [SurveyQuestions]([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SurveyAnswers_UserProfile] FOREIGN KEY (UserId) REFERENCES [UserProfile]([Id]) ON DELETE NO ACTION,
)