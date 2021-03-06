-----------------------------Delete database if exists----------------------------
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'QuizBee')
BEGIN 
	--Take database offline ignoring any connection made
	ALTER DATABASE [QuizBee] SET OFFLINE WITH ROLLBACK IMMEDIATE;

	--Bring online before delete 
	ALTER DATABASE [QuizBee] SET ONLINE;

	DROP DATABASE [QuizBee]; 

END 

-----------------------------Create database----------------------------------------

CREATE DATABASE [QuizBee];
USE [QuizBee]
GO
-----------------------------Create the QuizL1 Table----------------------------------
CREATE TABLE [dbo].[QuizL1](
	[QuestionNumber] [int] NOT NULL,
	[Questions] [varchar](max) NOT NULL,
	[Option1] [varchar](max) NOT NULL,
	[Option2] [varchar](max) NOT NULL,
	[Option3] [varchar](max) NOT NULL,
	[Option4] [varchar](max) NOT NULL,
	[TimeFrame] [int] NOT NULL,
	[AnswerKey] [varchar](255) NOT NULL,
	[DifficultyLevel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-----------------------------Create the QuizL2 Table----------------------------------
CREATE TABLE [dbo].[QuizL2](
	[QuestionNumber] [int] NOT NULL,
	[Questions] [varchar](max) NOT NULL,
	[Option1] [varchar](max) NOT NULL,
	[Option2] [varchar](max) NOT NULL,
	[Option3] [varchar](max) NOT NULL,
	[Option4] [varchar](max) NOT NULL,
	[TimeFrame] [int] NOT NULL,
	[AnswerKey] [varchar](255) NOT NULL,
	[DifficultyLevel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-----------------------------Create the QuizL3 Table----------------------------------
CREATE TABLE [dbo].[QuizL3](
	[QuestionNumber] [int] NOT NULL,
	[Questions] [varchar](max) NOT NULL,
	[Option1] [varchar](max) NOT NULL,
	[Option2] [varchar](max) NOT NULL,
	[Option3] [varchar](max) NOT NULL,
	[Option4] [varchar](max) NOT NULL,
	[TimeFrame] [int] NOT NULL,
	[AnswerKey] [varchar](255) NOT NULL,
	[DifficultyLevel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-----------------------------Create the Clincher Table----------------------------------
CREATE TABLE [dbo].[Clincher](
	[QuestionNumber] [int] NOT NULL,
	[Questions] [varchar](max) NOT NULL,
	[Option1] [varchar](max) NOT NULL,
	[Option2] [varchar](max) NOT NULL,
	[Option3] [varchar](max) NOT NULL,
	[Option4] [varchar](max) NOT NULL,
	[TimeFrame] [int] NOT NULL,
	[AnswerKey] [varchar](255) NOT NULL,
	[DifficultyLevel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-----------------------------Create the GenericQuiz Table----------------------------------
CREATE TABLE [dbo].[GQuiz](
	[QuestionNumber] [int] NOT NULL,
	[Questions] [varchar](max) NOT NULL,
	[Option1] [varchar](max) NOT NULL,
	[Option2] [varchar](max) NOT NULL,
	[Option3] [varchar](max) NOT NULL,
	[Option4] [varchar](max) NOT NULL,
	[TimeFrame] [int] NOT NULL,
	[AnswerKey] [varchar](255) NOT NULL,
	[DifficultyLevel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


-----------------------------Create the Contestant Score Table-------------------------
CREATE TABLE [dbo].[ContestantScore](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContestantName] [nvarchar](50) NULL,
	[Score] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-----------------------------Create the GContestant Score Table-------------------------
CREATE TABLE [dbo].[GContestantScore](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContestantName] [nvarchar](50) NULL,
	[Score] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-----------------------------Create the Participants Table-------------------------
CREATE TABLE [dbo].[Participants](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeamName] [varchar](max) NULL,
	[Participant1] [varchar](max) NULL,
	[Participant2] [varchar](max) NULL,
	[Participant3] [varchar](max) NULL,
	[Participant4] [varchar](max) NULL,
	[Participant5] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-----------------------------Create the GParticipants Table-------------------------
CREATE TABLE [dbo].[GParticipants](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeamName] [varchar](max) NULL,
	[Participant1] [varchar](max) NULL,
	[Participant2] [varchar](max) NULL,
	[Participant3] [varchar](max) NULL,
	[Participant4] [varchar](max) NULL,
	[Participant5] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[AdminAccount](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AdminAccount] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[TallySheet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContestantName] [nvarchar](50) NOT NULL,
	[QuestionNumber] [int] NOT NULL,
	[Answer] [varchar](250) NULL,
	
 CONSTRAINT [PK_TallySheet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[GTallySheet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContestantName] [nvarchar](50) NOT NULL,
	[QuestionNumber] [int] NOT NULL,
	[Answer] [varchar](250) NULL,
	
 CONSTRAINT [PK_GTallySheet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


-----------------------------Prepare Sample Data---------------------------------- 
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (1, N'The accounting equation can be stated as:', N'A + L-OE = 0', N'A-L + OE = 0', N'-A + L-OE = 0', N'A-L-OE = 0', 5, N'A-L-OE = 0', 1)
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (2, N'Incurring an expense for advertising on account would be recorded by:', N'Debiting liabilities', N'Crediting assets', N'Debiting an expense', N'Debiting assets', 10, N'Debiting an expense', 1)
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (3, N'Hughes Aircraft sold a four-passenger airplane for P380,000, receiving a P50,000 down payment and a 12% note for the balance. The journal entry to record this sale would include a', N'Credit to cash', N'Debit to cash discount', N'Debit to note receivable', N'Credit to note receivable', 15, N'Debit to note receivable', 2)
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (4, N'If, during an accounting period, an expense item has been incurred and consumed but not yet paid for or recorded, then the end-of-period adjusting entry would involve', N'a liability account and an asset account', N'an asset or contra asset account and an expense account', N'a liability account and an expense', N'a receivable account and a revenue account', 20, N'a liability account and an expense', 2)
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (5, N'Year-end net assets would be overstated and current expenses would be understated as a result of failure to record which of the following adjusting entries?', N'Expiration of prepaid insurance', N'Depreciation of fixed assets', N'Accrued wages payable', N'All of these', 25, N'All of these', 3)
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (6, N'Which of the following would most likely be found in an adjusting entry?', N'Prepaid expenses', N'Accounts receivable', N'Cash dividend paid', N'Sales on account', 30, N'Prepaid expenses', 3)
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (7, N'The debit and credit analysis of a transaction normally takes place', N'before an entry is recorded in a journal', N'when the entry is posted to the ledger', N'when the trial balance is prepared', N'at some other point in the accounting cycle', 25, N'before an entry is recorded in a journal', 3)
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (8, N'Recording revenue earned from a customer, but not yet collected, is an example of', N'A prepaid expense transaction', N'An unearned revenue transaction', N'An accrued liability transaction', N'An accrued receivable transaction', 30, N'An accrued receivable transaction', 1)
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (9, N'Entity A acquired an asset that had a cost of P130,000.  The asset is being depreciated over a 5-year period using the sum-of-the-years’ digit method.  It has a salvage value estimated at P10,000.  The loss/gain if the asset is sold for P38,000 at the end of the third year is ', N'P4,000 gain', N'P20,000 loss', N'P68,000 loss', N'P92,000 loss', 20, N'P4,000 gain', 2)
INSERT [dbo].[QuizL1] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (10, N'Simulation of a contract may be absolute or relative. It is relative when', N'The parties do not intend to be bound at all', N'The contract is void', N'The parties conceal their true agreement', N'The intention of the parties is uncertain', 25, N'The parties conceal their true agreement', 3)

--Generic--
INSERT [dbo].[GQuiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (1, N'This is how a robot decides when or how to do something', N'signal', N'source control', N'program', N'none of the above', 25, N'program', 1)
INSERT [dbo].[GQuiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (2, N'Who is the father of Artificial Intelligence', N'Steve Jobs ', N'Bill Gates ', N'Dennis Ritchie', N'John McCarthy', 15, N'John McCarthy', 2)
INSERT [dbo].[GQuiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (3, N'First digitally operated and programmable robot', N'ASIMO', N'Unimate', N'Martian Rover', N'none of the above', 20, N'program', 3)
INSERT [dbo].[GQuiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (4, N'Initiated the Java language project in June 1991.', N'James Gosling', N'Mike Sheridan', N'Patrick Naughton', N'All of the above', 30, N'James Gosling', 1)
INSERT [dbo].[GQuiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (5, N'The name of a variable is known as its', N'identifier', N'constant', N'data type', N'base', 20, N'identifier', 2)
INSERT [dbo].[GQuiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (6, N'In Java, the % refers to', N'percentages', N'modulus operator', N'division', N'data storage', 15, N'modulus operator', 3)
INSERT [dbo].[GQuiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (7, N'Which of the following elds is not an influence on HCI?', N'ergonomics', N'cognitive psychology', N'computer science', N'all of the above are an influence on HCI', 15, N'all of the above are an influence on HCI', 1)
INSERT [dbo].[GQuiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (8, N'Scripting (the ability to record and play back programmable sequences of actions) is an example of:', N'speaking the users language', N'allowing the user model to grow', N'the recognition rather than recall principle', N'a mode in the user interface design', 25, N'allowing the user model to grow', 2)
INSERT [dbo].[GQuiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (9, N'An icon of a le folder, which users can drop les on in order to move them into the folder, is an example of which of the following:', N'the recognition rather than recall principle', N'direct manipulation', N'a metaphor', N'all of the above', 20, N'program', 3)

--Admin Account
SET IDENTITY_INSERT [dbo].[AdminAccount] ON
INSERT [dbo].[AdminAccount] ([Id], [UserName], [Password], [FullName]) VALUES (1, N'Admin', N'@dm!n', N'Administrator')
SET IDENTITY_INSERT [dbo].[AdminAccount] OFF