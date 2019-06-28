set user="cookHub_admin"
set password="panties7890"
set server="LAPTOP-P3338OQH"
set currentPath=%~dp0

sqlcmd -S %server% -i startup.sql

sqlcmd -S %server% -i drop_user.sql
sqlcmd -S %server% -i create_user.sql

sqlcmd -S %server% -i drop_database.sql
sqlcmd -S %server% -i create_database.sql

sqlcmd -S %server% -i tables\user\role.sql
sqlcmd -S %server% -i tables\user\user.sql
sqlcmd -S %server% -i tables\user\userImage.sql


sqlcmd -S %server% -i tables\recipe\recipe.sql
sqlcmd -S %server% -i tables\recipe\ingredient.sql
sqlcmd -S %server% -i tables\recipe\ingredientDetails.sql
sqlcmd -S %server% -i tables\recipe\recipeImage.sql
sqlcmd -S %server% -i tables\recipe\recipe_ingredient_details.sql

sqlcmd -S %server% -i inserts\user\role.sql
sqlcmd -S %server% -i inserts\user\user.sql
sqlcmd -S %server% -i inserts\user\userImage.sql

sqlcmd -S %server% -i inserts\recipe\ingredient.sql
sqlcmd -S %server% -i inserts\recipe\ingredientDetails.sql
sqlcmd -S %server% -i inserts\recipe\recipe.sql
sqlcmd -S %server% -i inserts\recipe\recipe_ingredient_details.sql
sqlcmd -S %server% -i inserts\recipe\recipeImage.sql

pause
