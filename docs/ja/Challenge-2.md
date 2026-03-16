# ボーナスチャレンジ

## チャレンジ 2: Entity Framework Core でデータベース統合

**難易度:** 🔥🔥 上級

!!! info
    静的な JSON データソースをリアルなデータベースに置き換えて、さらに発展させましょう。

このチャレンジでは、Entity Framework Core（EF Core）を使って静的 JSON ファイルを SQL Server または SQLite データベースに置き換え、C# の Weather API を強化します。データの永続化・マイグレーション・非同期データベース操作を実際に体験できる、現実に近いシナリオです。

### 学習目標

このチャレンジを完了することで、以下を習得できます:

- Entity Framework Core を ASP.NET Core Minimal API に統合する方法
- データベース操作を管理するためのデータモデルと DbContext の作成
- データベースマイグレーションとスキーマ管理の基礎
- データベースクエリへの async/await パターンの適用
- データリポジトリパターンへの依存性注入の活用

#### チャレンジのステップ

**ステップ 1: Entity Framework Core のセットアップ**

Agent モードで GitHub Copilot を使って:

1. C# プロジェクトに Entity Framework Core の NuGet パッケージを追加する（例: `Microsoft.EntityFrameworkCore`、`Microsoft.EntityFrameworkCore.Sqlite` または `Microsoft.EntityFrameworkCore.SqlServer`）
2. `weather.json` の構造をもとに適切なデータモデル（Country・Weather・City エンティティ）を作成する
3. `DbContext` を継承してデータベーステーブルを定義する `WeatherDbContext` クラスを作成する

!!! tip
    `weather.json` ファイルを分析して適切なエンティティモデルとリレーションを提案してもらうよう Copilot に依頼しましょう。

**ステップ 2: データベースの設定とマイグレーションの作成**

Agent モードで:

1. `Program.cs` にデータベース接続を設定する
2. `dotnet ef migrations add` を使って初回のデータベースマイグレーションを作成する
3. `dotnet ef database update` でデータベーススキーマを更新する

!!! important
    Copilot が `Program.cs` を変更したりマイグレーションファイルを作成したりする際は、その操作をよく確認してください。生成されたマイグレーションコードを見て、どのようなスキーマ変更が適用されるかを理解しましょう。

**ステップ 3: 初期データのシード**

Agent モードで:

1. `weather.json` の気象データをデータベースに移入するシード処理を作成する
2. アプリケーション起動時にシードロジックを呼び出す

!!! note
    既存の JSON ファイルからシードすることで、データベースに元の静的データと同じ情報が格納されます。

**ステップ 4: エンドポイントをデータベースを使うように更新**

Agent モードを使ってエンドポイントを更新する:

1. エンドポイントハンドラーに `WeatherDbContext` をインジェクトする
2. JSON ファイルの読み込みを EF Core のデータベースクエリに置き換える
3. すべてのデータベース操作に async/await パターンを使う
4. すべてのエンドポイントがこれまでと同じレスポンスを返すことを確認する

!!! success
    エンドポイントを更新したら、Python テストを実行してデータベースバックエンドでも API が正しく動作することを確認しましょう。

**ステップ 5: 検証とテスト**

Python テストスイートを使って以下を検証する:

1. `/` エンドポイントが 200 を返す
2. `/countries` エンドポイントが正しい国リストを返す
3. weather エンドポイントが有効な国に対して正しいデータを返す
4. 無効な国に対して 404 レスポンスが返る

これまでと同じ方法でテストを実行します:

```bash
cd src/python-app/webapp
pytest test_main.py -v
```

### オプションの発展課題

- countries エンドポイントへのフィルタリングとページネーションの追加
- リレーション付きのより複雑なデータモデルの実装
- モック DbContext を使った xUnit の C# ユニットテストの作成
- インデックスを使ったクエリパフォーマンスの最適化
