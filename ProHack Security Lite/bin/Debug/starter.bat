REM : Script to start the application
@ECHO off

REM : First time file
SET FIRST_TIME_FILE="FIRST_TIME"

REM : If first time file exists
IF EXIST %FIRST_TIME_FILE% (
	REM : Start the easy dependency downloader
	START "" "ProHack Easy Install\ProHack Easy Install\bin\Debug\ProHack Easy Install.exe"
	REM : Delete the first time file
	DEL /F %FIRST_TIME_FILE%
) ELSE (
	REM : Start the app
	START "" "ProHack Security Lite.exe"
)
REM : Exit this script
EXIT