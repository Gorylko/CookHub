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


sqlcmd -S %server% -i tables\recipe\category.sql
sqlcmd -S %server% -i tables\recipe\recipe.sql
sqlcmd -S %server% -i tables\recipe\ingredient.sql
sqlcmd -S %server% -i tables\recipe\recipeImage.sql
sqlcmd -S %server% -i tables\recipe\units.sql
sqlcmd -S %server% -i tables\recipe\recipeInfo.sql

sqlcmd -S %server% -i inserts\user\role.sql
sqlcmd -S %server% -i inserts\user\user.sql
sqlcmd -S %server% -i inserts\user\userImage.sql

sqlcmd -S %server% -i inserts\recipe\ingredient.sql
sqlcmd -S %server% -i inserts\recipe\category.sql
sqlcmd -S %server% -i inserts\recipe\recipe.sql
sqlcmd -S %server% -i inserts\recipe\units.sql
sqlcmd -S %server% -i inserts\recipe\recipeInfo.sql
sqlcmd -S %server% -i inserts\recipe\recipeImage.sql

sqlcmd -S %server% -i functions\func_get_category_by_id.sql
sqlcmd -S %server% -i functions\func_get_unit_by_id.sql

sqlcmd -S %server% -i sp\select\sp_select_images_by_user_id.sql
sqlcmd -S %server% -i sp\select\sp_select_user_by_id.sql
sqlcmd -S %server% -i sp\select\sp_select_user_by_recipe_id.sql
sqlcmd -S %server% -i sp\select\sp_select_ingredients_by_recipe_id.sql
sqlcmd -S %server% -i sp\select\sp_select_images_by_recipe_id.sql
sqlcmd -S %server% -i sp\select\sp_select_recipe_by_id.sql
sqlcmd -S %server% -i sp\select\sp_select_recipes.sql

pause
