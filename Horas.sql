USE [pavTpGrupal]
GO

INSERT INTO [dbo].[horas]
           ([legajo]
           ,[codigo_proyecto]
           ,[id_etapa_proyecto]
           ,[fecha]
           ,[horas])
     VALUES
           (1234
           ,17
           ,1
           ,dateadd(day, -2, getdate())
           ,5)
GO

/*
16 NX
17 neware

Id	Nombre
1	Modelado de Negocio
2	Requerimientos
3	An�lisis
4	Dise�o
5	Implementaci�n
6	Prueba
7	Mantenimiento
8	Finalizado
*/