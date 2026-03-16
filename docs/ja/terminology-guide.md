# ドキュメント用語ガイド

このガイドは WRK541 ワークショップのドキュメント全体で使用する用語を統一し、明確さとプロフェッショナルな品質を確保するためのものです。

## 製品の正式名称

### 初出時は必ず正式名称を使用する

**GitHub Copilot**
: 各ドキュメントで最初に言及する際は「GitHub Copilot」と表記し、以降は「Copilot」と略記してよい。
: ✅ 「GitHub Copilot はコード作成を支援します。Copilot は AI を活用して…」
: ❌ 「Copilot はコード作成を支援します」（初出で略記しない）

**ASP.NET Core Minimal APIs**
: 常に「ASP.NET Core」と「Minimal APIs」を大文字で表記する
: ✅ 「ASP.NET Core Minimal APIs」
: ❌ 「Asp.net core minimal apis」や「minimal API」

**FastAPI**
: 1 語でF と API を大文字にする
: ✅ 「FastAPI」
: ❌ 「Fast API」や「fast-api」

**.NET**
: 常に NET の前にピリオドを付けて大文字で表記する
: ✅ 「.NET 10」または「.NET SDK」
: ❌ 「dotnet」や「Net」（コマンドラインツール `dotnet` を指す場合を除く）

**Visual Studio Code**
: 初出は正式名称を使用し、以降は「VS Code」と略記してよい
: ✅ 「Visual Studio Code」（初出）、「VS Code」（以降）
: ❌ 「VSCode」や「Visual Studio」（別製品のため）

## Copilot のモード名

各モード名は Copilot の具体的な機能を指す場合は常に大文字で始める:

- **Ask モード**（「ask mode」や「Askモード」は使わない）
- **Agent モード**（「agent mode」は使わない）
- **Plan モード**（「plan mode」は使わない）

例: 「Agent モードを使ってプロジェクトの雛形を作成してください」✅

## フレームワーク・ライブラリ名

**Python**
: 常に大文字で始める
: ✅ 「Python 3.12」
: ❌ 「python」

**C#**
: 大文字の C に # 記号を続ける
: ✅ 「C#」
: ❌ 「c#」や「csharp」（ファイルパス内を除く）

**JSON**
: 常にすべて大文字
: ✅ 「JSON ファイル」
: ❌ 「json」や「Json」

**Swagger**
: ツール名として言及する場合は先頭を大文字にする
: ✅ 「Swagger のドキュメント」

**OpenAPI**
: O と API の両方を大文字にする
: ✅ 「OpenAPI 仕様」
: ❌ 「Open API」や「openapi」

## テストフレームワーク

**pytest**
: 小文字、1 語
: ✅ 「pytest」
: ❌ 「PyTest」や「Pytest」

**MSTest**
: 大文字の MS に続けて大文字の T
: ✅ 「MSTest」
: ❌ 「mstest」や「Ms Test」

## ファイルとコードの参照

**Program.cs**
: ファイルを指す場合は正確な大文字・小文字の表記を使う
: ✅ 「`Program.cs`」
: ❌ 「`program.cs`」や「Program.CS」

**main.py**
: ファイルを指す場合は小文字で表記する
: ✅ 「`main.py`」
: ❌ 「`Main.py`」

**weather.json**
: データファイルは小文字で表記する
: ✅ 「`weather.json`」

## 技術用語

**API エンドポイント（API Endpoint）**
: 2 語。文頭以外では小文字で始める
: ✅ 「API エンドポイントは気象データを返します」

**リポジトリ（Repository / Repo）**
: 正式なドキュメントでは「リポジトリ」、フォーマルさを求めない場面では「repo」を使う

**GitHub Codespaces**
: 2 語、いずれも先頭を大文字にする
: ✅ 「GitHub Codespaces」
: ❌ 「Github Codespaces」や「GitHub codespaces」

**ポート番号（Port Number）**
: ネットワークポートを指す場合は「ポート」を使う
: ✅ 「ポート 8000」

## コマンドラインツール

**dotnet**
: コマンドラインツールを指す場合は小文字
: ✅ 「`dotnet build`」
: ❌ 「`Dotnet build`」

**git**
: コマンドを指す場合は小文字
: ✅ 「`git status`」
: ❌ 「`Git status`」

**pip**
: 小文字
: ✅ 「`pip install`」
: ❌ 「`PIP install`」

## ドキュメントのスタイル

### 見出しの表記

主要な見出しはタイトルケース（各単語の先頭を大文字）を使う:
✅ 「プロジェクトを理解する」
✅ 「Understanding the Project」（英語の場合）

### リストと箇条書き

- 各箇条書きは大文字で始める
- 完全な文の場合は句点（。または.）で終える
- フラグメントや単語のみの場合は句点不要
