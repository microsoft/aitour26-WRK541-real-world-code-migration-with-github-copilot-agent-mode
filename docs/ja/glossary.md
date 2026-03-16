# 用語集

このワークショップ全体を通じて登場する重要な用語の定義をまとめています。知らない言葉に出会ったときのクイックリファレンスとして活用してください。

## API 関連の用語

**API（Application Programming Interface）**
: 異なるソフトウェアアプリケーションが互いに通信するための規則とプロトコルのセット。

**エンドポイント（Endpoint）**
: `/countries` や `/weather` のように、特定の処理を担う API の URL パス。

**REST（Representational State Transfer）**
: HTTP の標準メソッド（GET・POST・PUT・DELETE）を使ってネットワークアプリケーションを設計するためのアーキテクチャスタイル。

**JSON（JavaScript Object Notation）**
: 人間にとって読み書きしやすく、プログラムにとって解析・生成しやすい軽量データフォーマット。

**HTTP メソッド**
: GET（データ取得）・POST（データ作成）・PUT（データ更新）・DELETE（データ削除）などの標準リクエストタイプ。

**ステータスコード（Status Code）**
: サーバーがリクエスト結果を示すために返す 3 桁の数値（例: 200 OK・404 Not Found・500 Internal Server Error）。

**Swagger/OpenAPI**
: REST API のドキュメント化のための仕様とツール群。インタラクティブなドキュメントとテストインターフェースを提供する。

## .NET と C# の用語

**ASP.NET Core**
: モダンな Web アプリケーションと API を構築するためのクロスプラットフォームの高性能フレームワーク。

**Minimal APIs**
: ASP.NET Core において最小限のコードと設定で API を作成するための簡略化されたアプローチ。

**.NET SDK（Software Development Kit）**
: .NET アプリケーションのビルドと実行に必要なツール・ライブラリ・ランタイムのセット。

**ランタイム（Runtime）**
: .NET アプリケーションを実行し、メモリ・セキュリティ・その他のシステムサービスを管理する実行環境。

**NuGet**
: .NET のパッケージマネージャー。サードパーティのライブラリや依存関係のインストールと管理に使う。

**System.Text.Json**
: JSON データのシリアライズとデシリアライズのための .NET 組み込みライブラリ。

**Program.cs**
: .NET アプリケーションのエントリポイントファイル。アプリケーションの設定と起動処理が記述される。

**ネームスペース（Namespace）**
: 関連するクラスをグループ化して命名の競合を防ぐ .NET のコード整理の仕組み。

## Python 関連の用語

**FastAPI**
: インタラクティブなドキュメントを自動生成できる、モダンで高速な Python の Web フレームワーク。

**Uvicorn**
: Python の Web アプリケーションを実行するための ASGI（Asynchronous Server Gateway Interface）Web サーバー。

**pytest**
: Python のシンプルかつ高機能なテストフレームワーク。このワークショップでは API エンドポイントのテストに使う。

**pip**
: Python のパッケージインストーラー。`requirements.txt` に記載された依存関係のインストールに使う。

**ASGI（Asynchronous Server Gateway Interface）**
: 非同期 Python Web アプリケーションとサーバー間の標準インターフェース。

## テスト関連の用語

**ユニットテスト（Unit Test）**
: アプリケーションの個々のコンポーネント（通常は関数やメソッド）を単独でテストするもの。

**統合テスト（Integration Test）**
: 複数のコンポーネントや API コールなど、システムの複数部分の連携をテストするもの。

**テストカバレッジ（Test Coverage）**
: テストによって実行されるコードの割合を示す指標。

**MSTest**
: Microsoft が提供する .NET のユニットテストフレームワーク。

**WebApplicationFactory**
: ASP.NET Core アプリケーションをテスト用にホストするための .NET テストユーティリティ。

## GitHub Copilot の用語

**Ask モード（Ask Mode）**
: コードを変更せずに質問への回答・コードの説明・提案を行う GitHub Copilot の Q&A モード。

**Agent モード（Agent Mode）**
: ファイル編集・コマンド実行・複数ステップにまたがるタスクを自律的に実行できる GitHub Copilot の高度なモード。

**Plan モード（Plan Mode）**
: タスクを実行前に構造化された計画に分解することを支援する GitHub Copilot のモード。

**インラインチャット（Inline Chat）**
: エディター内で直接 GitHub Copilot と対話できる機能。特定のコードに対してその場で変更を依頼できる。

**Copilot Instructions**
: Copilot の動作をガイドするためのプロジェクト固有のインストラクションファイル（`.github/instructions/` フォルダに置く）。

**`#codebase`**
: GitHub Copilot Chat でリポジトリ全体をコンテキストとして参照するためのプロンプト変数。

**`#file:ファイル名`**
: GitHub Copilot Chat で特定のファイルをコンテキストとして参照するためのプロンプト変数。

## 開発ツール

**VS Code（Visual Studio Code）**
: Microsoft が開発した無料のオープンソースコードエディター。このワークショップのメイン IDE。

**GitHub Codespaces**
: クラウド上でホストされる開発環境。ブラウザから VS Code を使って開発できる。

**dotnet CLI**
: .NET アプリケーションの作成・ビルド・実行・テストのためのコマンドラインツール。

**Swagger UI**
: OpenAPI 仕様から自動生成される API の対話型ドキュメント。ブラウザから直接エンドポイントをテストできる。

## 一般的なプログラミング用語

**プロジェクト雛形の生成（Scaffolding）**
: プロジェクトやコンポーネントの基本構造と定型コードをツールが自動生成すること。「雛形（ひながた）」とも呼ばれる。

**デシリアライズ（Deserialization）**
: JSON や XML などのデータフォーマットをプログラミング言語のオブジェクトに変換するプロセス。

**マイグレーション（Migration）**
: 異なる言語・プラットフォーム・フレームワーク間でコードやデータを移行するプロセス。

**ボイラープレート（Boilerplate）**
: 繰り返し使われる定型的なコード。

**依存性注入（Dependency Injection）**
: オブジェクトがその依存関係を外部から受け取るデザインパターン。テスト容易性とモジュール性が向上する。

**非同期処理（Async/Await）**
: 処理をブロックせずに非同期オペレーションを扱う C# と Python のプログラミングパターン。
