set user="cookHub_admin"
set password="panties7890"
set server="LAPTOP-P3338OQH"
set currentPath=%~dp0

sqlcmd -S %server% -i startup.sql

sqlcmd -S %server% -i drop_user.sql
sqlcmd -S %server% -i create_user.sql

sqlcmd -S %server% -U %user% -P %password% -i drop_database.sql
sqlcmd -S %server% -i create_database.sql

sqlcmd -S %server% -i %currentPath%tables\user\user.sql
sqlcmd -S %server% -i tables\user\role.sql
sqlcmd -S %server% -i tables\user\userImage.sql

pause
