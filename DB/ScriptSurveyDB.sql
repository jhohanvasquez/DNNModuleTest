USE [DotNetNuke]
GO

/****** Object:  Table [dbo].[DNNModuleTest_Answers]    Script Date: 27/12/2020 07:48:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DNNModuleTest_Answers](
	[AnswerId] [int] IDENTITY(1,1) NOT NULL,
	[AnswerValue] [varchar](max) NULL,
	[QuestionId] [int] NULL,
	[AssignedUserId] [int] NULL,
	[ModuleId] [int] NULL,
	[CreatedByUserId] [int] NULL,
	[LastModifiedByUserId] [int] NULL,
	[CreatedOnDate] [datetime] NULL,
	[LastModifiedOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AnswerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[DNNModuleTest_Answers]  WITH CHECK ADD FOREIGN KEY([AnswerId])
REFERENCES [dbo].[DNNModuleTest_Answers] ([AnswerId])
GO


USE [DotNetNuke]
GO

/****** Object:  Table [dbo].[DNNModuleTest_Items]    Script Date: 27/12/2020 07:48:49 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DNNModuleTest_Items](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](max) NOT NULL,
	[ItemDescription] [nvarchar](max) NOT NULL,
	[AssignedUserId] [int] NULL,
	[ModuleId] [int] NOT NULL,
	[CreatedOnDate] [datetime] NOT NULL,
	[CreatedByUserId] [int] NOT NULL,
	[LastModifiedOnDate] [datetime] NOT NULL,
	[LastModifiedByUserId] [int] NOT NULL,
 CONSTRAINT [PK_DNNModuleTest_Items] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [DotNetNuke]
GO

/****** Object:  Table [dbo].[DNNModuleTest_Questions]    Script Date: 27/12/2020 07:49:06 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DNNModuleTest_Questions](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionName] [varchar](max) NULL,
	[QuestionType] [varchar](max) NULL,
	[AssignedUserId] [int] NULL,
	[ModuleId] [int] NULL,
	[CreatedByUserId] [int] NULL,
	[LastModifiedByUserId] [int] NULL,
	[CreatedOnDate] [datetime] NULL,
	[LastModifiedOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[DNNModuleTest_Questions]  WITH CHECK ADD FOREIGN KEY([QuestionId])
REFERENCES [dbo].[DNNModuleTest_Questions] ([QuestionId])
GO


