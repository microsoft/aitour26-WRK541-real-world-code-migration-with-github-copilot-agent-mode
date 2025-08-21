# Real World Code Migration with GitHub Copilot Agent Mode

The instructions for this workshop are published to GitHub Pages at
[aka.ms/aitour/wrk541](https://aka.ms/aitour/wrk541). This folder `docs` contains the source code for those instructions.

## MKDocs

These instructions are written using MKdocs, and mkdocs commands are installed in this dev container. For full documentation visit [mkdocs.org](https://www.mkdocs.org).

These instructions also make use of the following MKDocs extensions:

* [Material for MkDocs](https://squidfunk.github.io/mkdocs-material/)
* [glightbox MKDocs plugin](https://blueswen.github.io/mkdocs-glightbox/)

## Deploy to GitHub pages

To deploy the wokshop instuctions to GitHub Pages for this repository:

```
cd docs
mkdocs gh-deploy
```

### Other mkdocs commands

* `mkdocs serve` - Start the live-reloading ocs server.
* `mkdocs build` - Build the documentation site.
* `mkdocs -h` - Print help message and exit.

## Project layout

    mkdocs.yml    # The configuration file.
    docs/
        docs/
            index.md  # The documentation homepage.
            ...       # Other markdown pages, images and other files.

## View docs in your browser

This repo is configured to let you optionally browse the [documentation](./docs/) served locally with [MkDocs](https://www.mkdocs.org/).  

Please follow these steps to view the docs with MkDocs.

1. Install the `mkdocs-material` package
    ```bash
    pip install mkdocs-material
    ```

2. Run the `mkdocs serve` command from the root folder
    ```bash
    mkdocs serve
    ```
If you're running this repo in a GitHub Codespace, then you should be able to skip step 1.