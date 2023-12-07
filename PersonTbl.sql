USE [Task]
GO

/****** Object:  Table [dbo].[Person]    Script Date: 07/12/2023 09:50:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Person](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[TelePhone] [char](11) NULL,
	[Email] [varchar](255) NOT NULL
) ON [PRIMARY]
GO


