@echo off

ECHO PayPal Adaptive Accounts SDK for .NET
ECHO ======================================

SET VSTOOLS=%VS140COMNTOOLS%
IF "%VSTOOLS%"=="" GOTO :VS_NOT_FOUND

SET IDE_DIR=%VSTOOLS%\..\IDE
SET DEVENV="%IDE_DIR%\devenv.com"
%DEVENV% PayPalAdaptiveAccountsSDK.sln /build Release
GOTO :END

:VS_NOT_FOUND
ECHO Visual Studio 2015 was not found.

:END
