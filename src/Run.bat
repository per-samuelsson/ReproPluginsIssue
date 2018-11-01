@echo off

PUSHD Lib1
dotnet pack
POPD

PUSHD Lib2
dotnet build
nuget pack -OutputDirectory bin\Debug Lib2.nuspec
POPD

PUSHD App1
dotnet run
POPD

