import requests
import pytest
import os

# Get base URL from environment variable or use default
BASE_URL = os.getenv("BASE_URL", "http://localhost:8000")


def is_app_running():
    """Check if the app is running before attempting tests"""
    try:
        response = requests.get(BASE_URL, timeout=2)
        return response.status_code == 200
    except requests.exceptions.RequestException:
        return False


@pytest.fixture(scope="session", autouse=True)
def check_app_running():
    """Verify the app is running before running any tests"""
    if not is_app_running():
        pytest.skip(f"App is not running at {BASE_URL}. Please start the app before running tests.")


def test_root():
    """Test the root endpoint returns 200"""
    response = requests.get(f"{BASE_URL}/")
    assert response.status_code == 200


def test_countries():
    """Test the countries endpoint returns the correct list"""
    response = requests.get(f"{BASE_URL}/countries")
    assert response.status_code == 200
    assert sorted(response.json()) == ["England", "France", "Germany", "Italy", "Peru", "Portugal", "Spain"]


def test_weather_for_valid_country():
    """Test getting weather for a valid country"""
    response = requests.get(f"{BASE_URL}/countries/Spain/Seville/January")
    assert response.status_code == 200
    data = response.json()
    assert "high" in data
    assert data["high"] > 10


def test_weather_for_invalid_country():
    """Test getting weather for an invalid country returns 404"""
    response = requests.get(f"{BASE_URL}/weather/InvalidCountry")
    assert response.status_code == 404