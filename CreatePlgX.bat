@echo off
;;cd %~dp0

echo Deleting existing PlgX folder
rmdir /s /q PlgX

echo Creating PlgX folder
mkdir PlgX

echo Copying files
xcopy "QuickSearch" PlgX /s /e /exclude:PlgXExclude.txt

echo Compiling PlgX
echo "%~dp0PlgX"
"../KeePass2.x/Build/KeePass/Release/KeePass.exe" /plgx-create "%~dp0PlgX"

echo Releasing PlgX
move /y PlgX.plgx "Releases\Build Outputs\QuickSearch.plgx"

echo Cleaning up
rmdir /s /q PlgX
