@echo off
:exec

protoc -I . --csharp_out . --grpc_out . --plugin=protoc-gen-grpc=grpc_csharp_plugin.exe IUpdateService.proto

@echo �Ƿ����ִ�� Y or N��
set /p loop=
if %loop%==N exit
if %loop%==n exit
goto exec