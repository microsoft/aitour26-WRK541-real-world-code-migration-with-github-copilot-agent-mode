# C# プロジェクトの雛形を作成する

> *このステップ以降は GitHub Copilot の Agent モードを使います。*

プロジェクトとテストの全体像を把握できたら、C# プロジェクト雛形の作成に進みましょう。まず最初に、リポジトリ全体に適用される *Copilot Instructions* ファイルをカスタマイズします。このファイルはリポジトリのルートにある `.github/copilot-instructions.md` です。現在は Python に関する内容で事前設定されているので、これから行う C# 移行に向けた内容に**全体を置き換えます**。

!!! note "`.github/copilot-instructions.md` と `.github/instructions/` の違い"
    `.github/copilot-instructions.md` はリポジトリ全体で使われる単一の Copilot インストラクションファイルで、このリポジトリ内のすべてのチャットで自動的に読み込まれます。一方 `.github/instructions/` フォルダは別の仕組みで、`applyTo` フロントマターで指定されたパスを編集するときだけ有効になる、glob スコープ付きの複数のファイルを置くためのものです。これらのファイルは既に内容が入っており、このステップでは編集する必要はありません。

`.github/copilot-instructions.md` を開き、**ファイルの内容をすべて以下で置き換えてください**:

```markdown
# C# .NET 10 WebApi Migration Instructions

## Overview

This guide helps developers migrate the Python Weather API to C# .NET 10 using ASP.NET Core Minimal APIs.

## Requirements

- **Framework**: ASP.NET Core Minimal APIs (.NET 10)
- **JSON Serialization**: System.Text.Json (built-in)
- **API Documentation**: Swashbuckle (OpenAPI/Swagger support)

## Development Workflow

- **Build**: `dotnet build`
- **Run**: `dotnet run`
- **Test**: `dotnet test` (tests in `WeatherApi.Tests` directory)
- **API Docs**: Available at `/swagger` endpoint when running

## C# API Guidelines

- Use **Minimal APIs** for endpoint definitions in `Program.cs`
- Use **System.Text.Json** for all serialization
- Add Swashbuckle attributes to endpoints for automatic Swagger documentation
- Follow PascalCase for class names, camelCase for methods
- Example: See `src/csharp-app/WeatherApi/Program.cs`

## Key Files

- `src/csharp-app/WeatherApi/Program.cs` - API configuration and endpoints
- `src/csharp-app/WeatherApi.Tests/` - Unit tests
- `src/csharp-app/WeatherApi/Models.cs` - Data models
- `src/csharp-app/WeatherApi/weather.json` - Sample data
```

??? warning
     この作業を始める前に、新しいチャットセッションを開くと効果的です。これまでのコンテキストがリセットされ、GitHub Copilot が白紙の状態から作業を始められます。チャットウィンドウ上部の ![GitHub Copilot の新しいチャットボタン](./media/copilot-newchat.png) ボタンをクリックするだけです。

複数のステップにまたがる作業を行うので、**Agent モード** で進めます。Agent モードに切り替えたら、C# プロジェクトの雛形作成を依頼しましょう。プロジェクトを起動するためのステップバイステップの手順とコマンドも合わせて教えてもらいましょう。

??? question "ヒント"
     プロンプト *(Agent モード)*

    ```text
    `src` ディレクトリ内に `csharp-app` という新しいフォルダを作成してください。
    Python プロジェクトを移行するために、csharp-app フォルダに C# の雛形プロジェクトを作成してください。
    .NET Minimal APIs を使用すること。
    コードの移行は今はしないでください。
    後でプロジェクトを起動するための手順とコマンドを教えてください。
    動作する C# .NET 10 Web API プロジェクトに必要な最小限のコードのみ作成してください。
    ```

GitHub Copilot が雛形プロジェクトを作成したら、`csharp-app` フォルダに生成されたファイルを確認しましょう。`.csproj` ファイルと `Program.cs` ファイルが存在するはずです。

（任意）作成されたファイルとその役割について疑問がある場合は、GitHub Copilot に説明を求めてみましょう。
