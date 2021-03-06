USE [Xing]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchUser]    Script Date: 2018/11/17 18:04:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_SearchUser]
@userName varchar(10)= null,
@ageFrom int= null,
@ageTo int= null,
@hobby varchar(50)= null
as 
select * from [Xing].[dbo].[User] 
where (@userName IS NULL OR (UserName like '%' +@userName+'%'))
and (@ageFrom IS NULL OR (Age>@ageFrom))
and (@ageTo IS NULL OR (Age<@ageTo))
and (@hobby IS NULL OR (Hobby like '%' +@hobby+'%'))