#!/usr/bin/env bash

set -euo pipefail

base_url="${1:-http://localhost:8000}"

echo "Checking root endpoint"
curl -i "$base_url/"

echo
echo "Checking countries endpoint"
curl -i "$base_url/countries"

echo
echo "Checking sample weather endpoint"
curl -i "$base_url/weather?country=usa&city=miami&month=january"