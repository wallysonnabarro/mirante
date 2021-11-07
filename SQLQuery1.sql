/****** Script do comando SelectTopNRows de SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Nome]
      ,[Descricao]
      ,[Salario]
  FROM [OTecDB].[dbo].[Cargo]

  insert into [OTecDB].[dbo].[Cargo] values('Test', 'TESTES 1', 1200)

  select [Id]
  ,[Nome]
  ,[Descricao]
  ,[Salario] from  [OTecDB].[dbo].[Cargo]
  order by Id
  offset 0 rows
  fetch next 10 rows only