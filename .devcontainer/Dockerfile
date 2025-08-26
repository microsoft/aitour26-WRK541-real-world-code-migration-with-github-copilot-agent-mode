# See here for image contents: https://github.com/microsoft/vscode-dev-containers/tree/v0.245.0/containers/python-3/.devcontainer/base.Dockerfile

# [Choice] Python version (use -bullseye variants on local arm64/Apple Silicon): 3, 3.10, 3.9, 3.8, 3.7, 3.6, 3-bullseye, 3.10-bullseye, 3.9-bullseye, 3.8-bullseye, 3.7-bullseye, 3.6-bullseye, 3-buster, 3.10-buster, 3.9-buster, 3.8-buster, 3.7-buster, 3.6-buster
ARG VARIANT="3.12-bullseye"
FROM mcr.microsoft.com/vscode/devcontainers/python:1-${VARIANT}
# Set environment variables
ENV DEBIAN_FRONTEND=noninteractive

# Install system dependencies and Rust
RUN apt-get update && apt-get install -y --no-install-recommends \
    curl \
    build-essential \
    libssl-dev \
    pkg-config \
    && apt-get clean && rm -rf /var/lib/apt/lists/* 
    
# Define the path to the virtualenv to work with
ARG VENV_PATH="/home/vscode/venv"

COPY workshop/python-app/requirements.txt /tmp/pip-tmp/
RUN su vscode -c "python -m venv /home/vscode/venv" \
   && su vscode -c "${VENV_PATH}/bin/pip --disable-pip-version-check --no-cache-dir install -r /tmp/pip-tmp/requirements.txt" \
   && rm -rf /tmp/pip-tmp \
   && echo '\n# Path to your virtual environment\nVIRTUAL_ENV_PATH="/home/vscode/venv"\n\n# Activate the virtual environment if it exists\nif [ -d "$VIRTUAL_ENV_PATH" ]; then\n    source "$VIRTUAL_ENV_PATH/bin/activate"\nfi\n' >> /home/vscode/.zshrc \
   && echo '\n# Path to your virtual environment\nVIRTUAL_ENV_PATH="/home/vscode/venv"\n\n# Activate the virtual environment if it exists\nif [ -d "$VIRTUAL_ENV_PATH" ]; then\n    source "$VIRTUAL_ENV_PATH/bin/activate"\nfi\n' >> /home/vscode/.bashrc
