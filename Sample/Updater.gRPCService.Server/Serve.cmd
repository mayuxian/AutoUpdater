@echo off
:exec

dotnet ./bin/Debug/netcoreapp2.2/Updater.gRPCService.Server.dll

@echo ÊÇ·ñ¼ÌÐøÖ´ÐÐ Y or N£¿
set /p loop=
if %loop%==N exit
if %loop%==n exit
goto exec