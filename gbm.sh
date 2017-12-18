#!/bin/sh -e
#check for all dependencies
for prog in mono readlink df 7za;do
    [ -n "`whereis -b ${prog} | cut -sd' ' -f2`" ] || (echo "Please install ${prog}" && exit 1);
done
for lib in libsqlite3;do
    [ -n "`ldconfig -p | grep ${lib}`" ] || (echo "Please install ${lib}" && exit 1);
done
DIR="$( cd "$( dirname "$(pwd)/$0" )" && pwd )";
echo "Located in ${DIR}";
GBMPATH='./';
#locate GBM.exe
if [ "${DIR}" = '/bin' ] && [ -s '/usr/share/gbm/GBM.exe' ]; then
    GBMPATH='/usr/share/gbm/';
elif [ "${DIR}" = '/usr/local/bin' ] && [ -s '/usr/local/share/gbm/GBM.exe' ]; then
    GBMPATH='/usr/local/share/gbm/';
elif [ ! -s './GBM.exe' ]; then
    echo 'GBM.exe not found';
    exit 2;
fi
mono --desktop ${GBMPATH}'GBM.exe' "$@";
exit $?;
