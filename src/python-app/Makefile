# Define the default target
.DEFAULT_GOAL := help

# Define variables
APP_MODULE := webapp.main:app
HOST := 0.0.0.0

# Define targets
run:
	/home/vscode/venv/bin/uvicorn --host $(HOST) $(APP_MODULE) --reload

help:
	@echo "Usage: make [target]"
	@echo ""
	@echo "Targets:"
	@echo "  run       Start the application using uvicorn"
	@echo "  help      use the command 'make run' to start the application"
.PHONY: help