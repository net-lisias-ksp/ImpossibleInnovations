#!/usr/bin/env bash

source ./CONFIG.inc

check() {
	if [ ! -d "./GameData/$TARGETBINDIR/" ] ; then
		rm -f "./GameData/$TARGETBINDIR/"
		mkdir -p "./GameData/$TARGETBINDIR/"
	fi
}

deploy_dev() {
	local DLL=$1.dll

	if [ -f "./bin/Release/$DLL" ] ; then
		cp "./bin/Release/$DLL" "$LIB"
	fi
}

deploy() {
	local DLL=$1.dll

	if [ -f "./bin/Release/$DLL" ] ; then
		cp "./bin/Release/$DLL" "./GameData/$TARGETBINDIR/"
		if [ -d "${KSP_DEV}/GameData/$TARGETBINDIR/" ] ; then
			cp "./bin/Release/$DLL" "${KSP_DEV/}GameData/$TARGETBINDIR/"
		fi
	fi
	if [ -f "./bin/Debug/$DLL" ] ; then
		if [ -d "${KSP_DEV}/GameData/$TARGETBINDIR/" ] ; then
			cp "./bin/Debug/$DLL" "${KSP_DEV}GameData/$TARGETBINDIR/"
		fi
	fi
}

deploy_plugindata() {
	local DLL=$1.dll

	if [ -f "./bin/Release/$DLL" ] ; then
		cp "./bin/Release/$DLL" "./GameData/$TARGETBINDIR/PluginData"
		if [ -d "${KSP_DEV}/GameData/$TARGETBINDIR/PluginData" ] ; then
			cp "./bin/Release/$DLL" "${KSP_DEV/}GameData/$TARGETBINDIR/PluginData"
		fi
	fi
	if [ -f "./bin/Debug/$DLL" ] ; then
		if [ -d "${KSP_DEV}/GameData/$TARGETBINDIR/PluginData" ] ; then
			cp "./bin/Debug/$DLL" "${KSP_DEV/}GameData/$TARGETBINDIR/PluginData"
		fi
	fi
}

VERSIONFILE=$PACKAGE.version

check
cp $VERSIONFILE "./GameData/$TARGETDIR"
cp CHANGE_LOG.md "./GameData/$TARGETDIR"
cp README.md  "./GameData/$TARGETDIR"
cp LICENSE* "./GameData/$TARGETDIR"
cp NOTICE "./GameData/$TARGETDIR"

for dll in $PD_DLLS ; do
    deploy_plugindata $dll
done

for dll in $DLLS ; do
    deploy_dev $dll
    deploy $dll
done
