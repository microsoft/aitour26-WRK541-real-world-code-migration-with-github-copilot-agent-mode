# ボーナスチャレンジ

## チャレンジ 3: モダンな AI 活用で移行を進める

**難易度:** 🔥🔥 上級

!!! info
    このチャレンジでは、既存ワークショップの流れをベースにしながら、より実務的で再利用しやすい AI 活用方法へ発展させます。

これまでのワークショップでは、VS Code 上で Ask モード、Plan モード、Agent モードを切り替えながら、その場でプロンプトを入力して作業を進めてきました。この方法は GitHub Copilot の基本的な使い方を学ぶには有効です。

一方で、実際の開発現場では、毎回長い指示をチャットに入力するよりも、プロジェクト側に AI 活用の前提条件や役割分担をファイルとして持たせるほうが効率的です。

このチャレンジでは、以下の考え方を使って、ワークショップの進め方をよりモダンな形へアップデートします。

- 共通ルールを `copilot-instructions.md` に集約する
- 領域別ルールを `*.instructions.md` として分離する
- 役割ごとの専用エージェントを `*.agent.md` で定義する
- 再利用可能な手順を `SKILL.md` と補助ファイルでスキル化する
- ターミナル作業を GitHub Copilot CLI や GitHub CLI と組み合わせて効率化する

## このチャレンジの学習目標

このチャレンジを完了すると、次のことを実践できるようになります。

- チャット中心の AI 活用から、再利用可能な AI 運用資産中心の進め方へ移行する
- `copilot-instructions.md` と `*.instructions.md` の役割分担を理解する
- planner / implementer / validator のようなマルチエージェント構成を設計する
- スキルを使って繰り返し作業をテンプレート化する
- CLI とエージェントを組み合わせて、実務に近いワークフローを組み立てる

## チャレンジのステップ

### ステップ 1: 共通ルールを `copilot-instructions.md` に整理する

まず、ワークショップ全体で共通になるルールを `.github/copilot-instructions.md` にまとめます。

例:

- Python 側を仕様の基準として扱う
- C# 側は .NET Minimal APIs を使う
- 変更は小さく分け、エンドポイント単位で検証する
- テストやビルドを壊したまま完了扱いにしない
- ドキュメントは日本人の開発者が理解しやすい表現を使う

!!! tip
    `copilot-instructions.md` は、すべての作業に共通して効いてほしい内容だけに絞るのが重要です。細かいルールまで詰め込みすぎると、コンテキストが重くなります。

### ステップ 2: 領域別の instructions を追加する

次に、対象ごとの補助ルールを `.github/instructions/` 配下に分けます。

たとえば、次の 3 つに分けると実務でも扱いやすくなります。

1. `python-analysis.instructions.md`
   - Python API とテストを仕様源として扱う
   - 既存のレスポンスやステータスコードを先に整理する
1. `csharp-migration.instructions.md`
   - Minimal APIs の実装方針
   - DTO、サービス分離、Swagger の方針
1. `testing.instructions.md`
   - `pytest` と `dotnet test` の使い分け
   - 互換性差分の報告ルール

### ステップ 3: マルチエージェント構成を導入する

このチャレンジでは、単一の Agent に何でもやらせるのではなく、役割ごとにエージェントを分ける構成を推奨します。

推奨構成:

1. `migration-planner.agent.md`
   - Python API を分析し、実装順序と検証順序を決める
1. `migration-implementer.agent.md`
   - C# 側の実装を小さな単位で進める
1. `migration-validator.agent.md`
   - `pytest`、`dotnet build`、`dotnet test` を使って検証する
1. `migration-orchestrator.agent.md`
   - planner / implementer / validator の橋渡しをする

!!! important
    planner に編集権限を与えない、validator に原則として編集権限を与えない、という制約をつけるだけでも、作業の見通しが大きく改善します。

### ステップ 4: スキルで繰り返し作業をテンプレート化する

次に、何度も繰り返す作業を `.github/skills/` 配下に切り出します。

このワークショップでは、少なくとも次のスキルが有効です。

- `analyze-python-api`
  - Python API の仕様抽出
- `create-csharp-minimal-api`
  - C# プロジェクト雛形の作成
- `validate-migration-parity`
  - Python / C# の互換性検証

スキルにしておくことで、単発の長いプロンプトを書く必要が減り、チームでも再利用しやすくなります。

### ステップ 5: CLI と組み合わせて検証を高速化する

AI との会話は設計と判断に寄せ、端末作業は CLI で小さく回すのが効果的です。

たとえば、次のようなコマンドを使い分けます。

```bash
rg "@app\.|def test_" src/python-app/webapp
cd src/python-app/webapp && pytest test_main.py -k countries -q
cd src/csharp-app && dotnet build
cd src/csharp-app && dotnet run --urls "http://localhost:8000"
curl -i http://localhost:8000/countries
```

環境によって GitHub Copilot CLI が使える場合は、`gh copilot` を併用してコマンド候補を生成してもよいでしょう。

```bash
gh copilot suggest "src/python-app/webapp/test_main.py の countries 関連テストだけを実行するコマンド"
gh copilot explain "dotnet run --urls http://localhost:8000"
```

!!! note
    利用環境によっては `gh copilot` サブコマンドが未導入の場合があります。その場合は先に導入可否を確認してください。

## 実務向けの推奨ワークフロー

このチャレンジでは、次のループで進めると効率的です。

### 仕様確認ループ

1. planner またはスキルで Python 仕様を整理する
1. `rg` や `pytest -k ...` で対象範囲を絞る
1. 期待動作を明文化する

### 実装ループ

1. implementer に 1 エンドポイント分だけ実装させる
1. `dotnet build` を実行する
1. `curl` で対象エンドポイントだけ確認する

### 検証ループ

1. validator で失敗箇所を再現する
1. Python 側の期待動作と比較する
1. 差分の原因を説明する
1. 必要なら implementer に最小修正を依頼する

## 発展課題

- `.github/copilot-instructions.md` をこのチャレンジ向けに実際に作成する
- `.github/instructions/` と `.github/agents/` の雛形を追加する
- `.github/skills/` にスキルを 1 つ以上追加する
- ワークショップ本文の「プロンプト例」を、agent / skill ベースの説明に書き換える

## 成果物のイメージ

このチャレンジを完了すると、単なるチャット履歴ではなく、チームで共有できる AI 活用資産がリポジトリに残ります。

- 共通ルール
- 領域別ルール
- 役割別エージェント
- 再利用可能なスキル
- 実行しやすい CLI レシピ

これにより、このワークショップは「GitHub Copilot のモードを試す教材」から、「実務で再利用できる AI 開発プロセスを設計する教材」へ発展します。