USE [pavTpGrupal]
GO

INSERT INTO [dbo].[empleadosEtapaProyecto]
           ([legajo]
           ,[cod_proyecto]
           ,[id_etapa]
           ,[fecha_inicio]
           ,[fecha_fin]
           ,[id_rol])
     VALUES
           (5660
           ,31
           ,2
           ,dateadd(day, -30, getdate())
           ,dateadd(day, 30, getdate())
           ,7)
GO


