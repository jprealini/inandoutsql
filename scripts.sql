/****** Script for SelectTopNRows command from SSMS  ******/
select top 1 action from activity
order by id desc

select * from activity

DBCC CHECKIDENT ('[Activity]', RESEED, 0) GO

select top 1 actionId from activity where userId = 1 order by id desc

exec Count_Hours 1, '01/01/2016','01/04/2016'