#!/bin/zsh
# Builds DGCharts.xcframework (device arm64 + simulator arm64/x86_64) from a Charts source tree with Xcode 26.6.
#
#   tools/build-xcframework.sh /path/to/Charts-5.1.0 [/path/to/output-dir]
#
# Pass the Xcode to use with DEVELOPER_DIR (defaults to Xcode26.6.app). Nothing in the Charts project needs
# patching: it already sets BUILD_LIBRARY_FOR_DISTRIBUTION=YES and SWIFT_VERSION=5.0, the Swift 5 ABI is stable,
# so no Xamarin.Swift runtime packages are needed anymore.
set -euo pipefail
SRC=${1:?path to the Charts checkout}
OUT=${2:-$(cd "$(dirname "$0")/.." && pwd)}
export DEVELOPER_DIR=${DEVELOPER_DIR:-/Applications/Xcode26.6.app/Contents/Developer}
BUILD=$(mktemp -d)
echo "Using $(xcodebuild -version | tr '\n' ' ')"
for dest in "generic/platform=iOS:iphoneos" "generic/platform=iOS Simulator:iphonesimulator"; do
  xcodebuild archive -project "$SRC/Charts.xcodeproj" -scheme DGCharts -configuration Release \
    -destination "${dest%%:*}" -archivePath "$BUILD/DGCharts-${dest##*:}.xcarchive" \
    SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES ONLY_ACTIVE_ARCH=NO -quiet
done
rm -rf "$OUT/DGCharts.xcframework"
xcodebuild -create-xcframework \
  -framework "$BUILD/DGCharts-iphoneos.xcarchive/Products/Library/Frameworks/DGCharts.framework" \
  -framework "$BUILD/DGCharts-iphonesimulator.xcarchive/Products/Library/Frameworks/DGCharts.framework" \
  -output "$OUT/DGCharts.xcframework"
find "$OUT/DGCharts.xcframework" -name .DS_Store -delete
echo "dSYMs left in $BUILD/*.xcarchive/dSYMs"
