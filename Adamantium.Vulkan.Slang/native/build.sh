#!/usr/bin/env bash
#
# Builds the slang-c-shared shim on Linux/macOS and stages it (+ the Slang runtime) next to the C# project.
# Slang is taken from $SLANG_DIR, else $VULKAN_SDK (the Vulkan SDK bundles Slang).
#   Usage:  ./native/build.sh [Release|Debug]
#
set -euo pipefail

NATIVE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJECT="$(dirname "$NATIVE")"
CONFIG="${1:-Release}"

SLANG="${SLANG_DIR:-${VULKAN_SDK:-}}"
if [ -z "$SLANG" ]; then
    echo "Set SLANG_DIR or VULKAN_SDK to a Slang / Vulkan SDK directory." >&2
    exit 1
fi

cmake -S "$NATIVE" -B "$NATIVE/build" -DCMAKE_BUILD_TYPE="$CONFIG" -DSLANG_DIR="$SLANG"
cmake --build "$NATIVE/build" --config "$CONFIG"

# Stage the shim (single-config generators emit to build/, multi-config to build/<Config>).
shim="$(find "$NATIVE/build" -maxdepth 2 -name 'libslang-c-shared.*' | head -n1)"
[ -n "$shim" ] && cp "$shim" "$PROJECT/"

# Stage the Slang runtime from the SDK (libslang.so / libslang.dylib).
runtime="$(find "$SLANG" -maxdepth 2 \( -name 'libslang.so*' -o -name 'libslang.dylib' \) | head -n1)"
[ -n "$runtime" ] && cp "$runtime" "$PROJECT/"

echo "OK: $(basename "${shim:-libslang-c-shared}") + Slang runtime -> $PROJECT"
