
echo Deleting existing PlgX folder

rm -rf Plgx/

mkdir Plgx

echo Copying files

ls QuickSearch -p|grep -if plgxExclude-linux.txt -v|xargs -I '{}' cp 'QuickSearch/{}' Plgx/ -r

echo Compiling Plgx
../KeePass-Source/Build/KeePass/Release/KeePass.exe -plgx-create Plgx

mkdir "Releases"
mkdir "Releases/Build Outputs/"

echo Releasing Plgx
mv Plgx.plgx "Releases/Build Outputs/QuickSearch.plgx"

rm -rf Plgx/
