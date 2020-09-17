/****** Script for SelectTopNRows command from SSMS  ******/
declare @login_name varchar

SELECT LoginName
into #Temp
  FROM [BSK_2].[MacSec].[Users]
  where ClearanceLevelNumber = 3

Declare @Id varchar(50)

While (Select Count(*) From #Temp) > 0
Begin

    Select Top 1 @Id = LoginName From #Temp

    --Do some processing here
	
	deny insert on object::dbo.PACJENCI to USER[@Id]

End
