
--Пока не юзается, и не факт что будет

USE MASTER;
GO

USE [master]
GO
EXEC xp_instance_regwrite N'HKEY_LOCAL_MACHINE', N'Software\Microsoft\MSSQLServer\MSSQLServer', N'LoginMode', REG_DWORD, 2
GO

ALTER LOGIN pavuk ENABLE;
GO
ALTER LOGIN pavuk WITH PASSWORD = 'panties7890';
GO