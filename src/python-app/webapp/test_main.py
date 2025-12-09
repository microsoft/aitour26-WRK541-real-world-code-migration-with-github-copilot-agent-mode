from main import app
from fastapi.testclient import TestClient

client = TestClient(app)


def test_root():
    response = client.get("/")
    assert response.status_code == 200


def test_countries():
    response = client.get("/countries")
    assert response.status_code == 200
    assert sorted(response.json()) == ["England", "France", "Germany", "Italy", "Peru", "Portugal", "Spain"]


def test_root_body():
    response = client.get("/")
    assert response.status_code == 200
    assert response.json() == {"documentation": "/docs"}


def test_monthly_success():
    response = client.get("/countries/England/London/January")
    assert response.status_code == 200
    assert response.json() == {"high": 45, "low": 36}


def test_monthly_country_not_found():
    response = client.get("/countries/Atlantis/London/January")
    assert response.status_code == 404
    assert response.json()["detail"] == "country not found"


def test_monthly_city_not_found():
    response = client.get("/countries/England/Nowhere/January")
    assert response.status_code == 404
    assert response.json()["detail"] == "city not found"


def test_monthly_month_not_found():
    response = client.get("/countries/England/London/Smarch")
    assert response.status_code == 404
    assert response.json()["detail"] == "month not found"


def test_content_type_json():
    response = client.get("/countries")
    assert response.headers["content-type"].startswith("application/json")