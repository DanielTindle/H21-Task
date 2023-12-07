USE [Task]
GO

/****** Object:  StoredProcedure [dbo].[SaveUser]    Script Date: 07/12/2023 09:51:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SaveUser]
@FullName varchar(50),
@DateOfBirth date,
@TelePhone char(11),
@Email varchar(255)

AS

INSERT into Person(FullName,DateOfBirth,TelePhone,Email) values(@FullName,@DateOfBirth,@TelePhone,@Email)

GO


