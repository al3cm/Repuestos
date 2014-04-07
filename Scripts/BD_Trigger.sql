use Autos
go

IF EXISTS( SELECT TOP 1 1 FROM sys.triggers WHERE name = 'tr_AumentaSkock')
	DROP TRIGGER tr_AumentaSkock 
GO


IF EXISTS( SELECT TOP 1 1 FROM sys.triggers WHERE name = 'tr_DisminuirSkock')
	DROP TRIGGER tr_DisminuirSkock 
GO
