@echo off
echo Setting up MySQL database...

set /p MYSQL_USER="Enter MySQL username (default: root): "
if "%MYSQL_USER%"=="" set MYSQL_USER=root

set /p MYSQL_PWD="Enter password for %MYSQL_USER%: "

set MYSQL_PATH="C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe"

if not exist %MYSQL_PATH% (
    echo MySQL not found at expected location.
    echo Please install MySQL manually from:
    echo https://dev.mysql.com/downloads/installer/
    pause
    exit /b
)

echo Importing database...
%MYSQL_PATH% -u %MYSQL_USER% -p%MYSQL_PWD% < "mysql\PetAppointmentDB.sql"

echo Done importing database.
pause
