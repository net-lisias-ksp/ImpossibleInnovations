source ../CONFIG.inc

PACKAGE=ImpossibleInnovations
TARGETDIR="$PACKAGE/"
TARGETBINDIR="$TARGETDIR/"
PROJECTSDIR="Source/$PACKAGE"

DLLS="ImpossibleInnovations"
PD_DLLS="KSP-1.3"

VERSION=$( cat $PACKAGE.version | tr '\n' ' ' | sed -n -E 's/^.*?"VERSION\":\{.*"MAJOR":([0-9]+?),.*?"MINOR":([0-9]+?),.*?"PATCH":([0-9]+?),.*?"BUILD":([0-9]+?).*?\}.*$/\1.\2.\3.\4/p' )
