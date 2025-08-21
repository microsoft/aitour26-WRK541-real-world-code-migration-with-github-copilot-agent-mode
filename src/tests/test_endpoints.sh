# Test the monthly average endpoint for Seville in June
GREEN='\033[0;32m'
RED='\033[0;31m'
RESET='\033[0m' # No Color

test_endpoint() {
    local url=$1
    local expected_status=$2
    local description=$3

    printf "[TEST] %-50s" "${description}"
    actual_status=$(curl -o /dev/null -s -w "%{http_code}" ${url})
    if [ "${actual_status}" -eq "${expected_status}" ]; then
        printf "${GREEN}[PASS]${RESET}\n"
    else
        printf "${RED}[FAIL]${RESET}\n\t- Expected: ${expected_status}, Got: ${actual_status}\n"
    fi
}

# Test the root endpoint
test_endpoint "http://localhost:8000/" 302 "root endpoint"

# Test the countries endpoint
test_endpoint "http://localhost:8000/countries" 200 "countries endpoint"

# Test the monthly average endpoint for London in January
test_endpoint "http://localhost:8000/countries/England/London/January" 200 "monthly average endpoint for London in January"
