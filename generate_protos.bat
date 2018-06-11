setlocal

@rem enter this directory
cd /d %~dp0

set TOOLS_PATH=packages\Grpc.Tools.1.8.0\tools\windows_x86

%TOOLS_PATH%\protoc.exe -I./protos --csharp_out Sql  protos/main.proto --grpc_out Sql --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe

endlocal