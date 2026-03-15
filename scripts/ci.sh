#!/usr/bin/env bash
# ci.sh - Pipeline local primeiroApp
# Usage: bash scripts/ci.sh [--fast] [--target android|windows]
set -euo pipefail

FAST=0
TARGET="windows"

for arg in "$@"; do
  case "$arg" in
    --fast) FAST=1 ;;
    --target) shift; TARGET="${1:-windows}" ;;
    --target=*) TARGET="${arg#*=}" ;;
  esac
done

FRAMEWORK="net10.0-windows10.0.19041.0"
[[ "$TARGET" == "android" ]] && FRAMEWORK="net10.0-android"

cd "$(dirname "$0")/.."
echo "[ci] build target=$TARGET framework=$FRAMEWORK"

# 1. Build
BUILD_OUT=$(dotnet build "primeiroApp.csproj" -f "$FRAMEWORK" 2>&1)
EXIT=$?
echo "$BUILD_OUT" | tail -6

if [[ $EXIT -ne 0 ]]; then
  echo "[ci] FAIL: build error"
  exit 1
fi

[[ $FAST -eq 1 ]] && echo "[ci] --fast: skip audit" && exit 0

# 2. Warning audit
BLOCKERS=$(echo "$BUILD_OUT" | grep -c ": error " || true)
WARNINGS=$(echo "$BUILD_OUT" | grep ": warning " || true)
MVVM=$(echo "$WARNINGS" | grep -c "MVVMTK" || true)
CS_WARN=$(echo "$WARNINGS" | grep -c "warning CS" || true)
OTHER=$(echo "$WARNINGS" | grep -vc "MVVMTK\|warning CS" || true)

echo ""
echo "[ci] --- Warning Audit ---"
echo "[ci] Bloqueadores : $BLOCKERS"
echo "[ci] MVVMTK (AOT) : $MVVM  [Degradacao - partial props p/ fix]"
echo "[ci] CS warnings  : $CS_WARN  [Divida tecnica]"
echo "[ci] Outros       : $OTHER"

if [[ $BLOCKERS -gt 0 ]]; then
  echo "[ci] FAIL: $BLOCKERS bloqueador(es)"
  exit 1
fi

echo "[ci] OK: build limpo (warnings classificados acima)"
exit 0
