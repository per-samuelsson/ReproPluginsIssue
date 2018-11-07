@echo off

PUSHD AspNetCoreWebApp
dotnet build
POPD

PUSHD App2
dotnet run
POPD