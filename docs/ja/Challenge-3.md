# ボーナスチャレンジ

## チャレンジ 3: モダンな AI 活用で移行を進める

**難易度:** 🔥🔥 上級

!!! info
    このチャレンジでは、既存ワークショップの流れをベースにしながら、より実務的で再利用しやすい AI 活用方法へ発展させます。

これまでのワークショップでは、VS Code 上で Ask モード、Plan モード、Agent モードを切り替えながら、その場でプロンプトを入力して作業を進めてきました。この方法は GitHub Copilot の基本的な使い方を学ぶには有効です。

一方で、実際の開発現場では、毎回長い指示をチャットに入力するよりも、プロジェクト側に AI 活用の前提条件や役割分担をファイルとして持たせるほうが効率的です。

このチャレンジでは、すでにリポジトリに追加されている instruction / agent / skill を実際に使いながら、ワークショップの進め方をよりモダンな形へアップデートします。

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

### ステップ 1: 既存の共通ルールを確認する

まず、ワークショップ全体で共通になるルールが `.github/copilot-instructions.md` にどのように整理されているかを確認します。

例:

- Python 側を仕様の基準として扱う
- C# 側は .NET Minimal APIs を使う
- 変更は小さく分け、エンドポイント単位で検証する
- テストやビルドを壊したまま完了扱いにしない
- ドキュメントは日本人の開発者が理解しやすい表現を使う

!!! tip
   `copilot-instructions.md` は、作業を始める前に一度確認しておくと効果的です。ここに書かれているルールが、以降の planner / implementer / validator の共通前提になります。

### ステップ 2: instructions の役割を確認する

次に、対象ごとの補助ルールが `.github/instructions/` 配下にどのように分かれているかを確認します。

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

### ステップ 3: マルチエージェント構成で進める

このチャレンジでは、単一の Agent に何でもやらせるのではなく、役割ごとに分かれたエージェントを使い分けます。

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

### ステップ 4: スキルを使って繰り返し作業を進める

次に、何度も繰り返す作業に対して `.github/skills/` 配下のスキルを使います。

このワークショップでは、少なくとも次のスキルが有効です。

- `analyze-python-api`
  - Python API の仕様抽出
- `create-csharp-minimal-api`
  - C# プロジェクト雛形の作成
- `validate-migration-parity`
  - Python / C# の互換性検証

スキルにしておくことで、単発の長いプロンプトを書く必要が減り、チームでも再利用しやすくなります。

## このチャレンジで実際に使うファイル

このチャレンジでは、以下のファイルを前提に作業します。

### 共通ルール

- `.github/copilot-instructions.md`

### instructions

- `.github/instructions/python-analysis.instructions.md`
- `.github/instructions/csharp-migration.instructions.md`
- `.github/instructions/testing.instructions.md`

### agents

- `.github/agents/migration-planner.agent.md`
- `.github/agents/migration-implementer.agent.md`
- `.github/agents/migration-validator.agent.md`
- `.github/agents/migration-orchestrator.agent.md`

### skills

- `.github/skills/analyze-python-api/SKILL.md`
- `.github/skills/create-csharp-minimal-api/SKILL.md`
- `.github/skills/validate-migration-parity/SKILL.md`

## agent / skill を前提にした作業の進め方

このチャレンジでは、以下の順番で作業するのが効果的です。

### パターン 1: オーケストレータ中心で進める

最も実務的なのは、`migration-orchestrator` を起点にして進める方法です。

1. `migration-orchestrator` を開く
1. 「Python API の次の未実装エンドポイントを分析して、実装と検証の順序を決めてください」と依頼する
1. orchestrator が planner に分析を委譲する
1. 返ってきた結果をもとに implementer に最小単位の実装を委譲する
1. 実装後に validator へ検証を委譲する

この方法では、利用者は毎回どの役割を選ぶべきかを細かく考えなくて済みます。

### パターン 2: 手動で agent を切り替えて進める

ワークショップとして役割の違いを学びたい場合は、次の順で手動切り替えする方法が向いています。

1. `migration-planner` で分析と計画を作る
1. `migration-implementer` で 1 エンドポイント分だけ実装する
1. `migration-validator` で `pytest` と `dotnet build` を使って検証する

この方法は、planner / implementer / validator の責務の違いを理解しやすいのが利点です。

## スキルを使った具体的な作業例

### 1. Python API の仕様を整理する

まず、`analyze-python-api` スキルを使って Python 側の仕様を整理します。

依頼例:

```text
/analyze-python-api src/python-app/webapp/main.py と test_main.py を確認し、
/countries と /weather の振る舞いを要約してください。
```

期待する出力:

- ルート一覧
- 入力パラメータ
- 正常系レスポンス
- 異常系レスポンス
- テストで保証されている内容

### 2. C# 側の次の実装を進める

次に、`create-csharp-minimal-api` スキルまたは `migration-implementer` を使って、最小単位で実装します。

依頼例:

```text
/create-csharp-minimal-api /countries エンドポイントだけを対象に、
Python 側と同じレスポンスになるよう最小限の C# 実装を進めてください。
```

または:

```text
migration-implementer を使って /countries だけ実装し、
変更ファイルと次に実行すべき検証コマンドを示してください。
```

### 3. 互換性を検証する

実装後は `validate-migration-parity` スキルまたは `migration-validator` を使って、挙動差分を確認します。

依頼例:

```text
/validate-migration-parity /countries の実装について、
Python の期待動作と一致しているか確認するための最小検証手順を示してください。
```

または:

```text
migration-validator を使って /countries 関連の pytest と C# build を確認し、
差分があれば原因を説明してください。
```

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

1. `analyze-python-api` スキル、または `migration-planner` で Python 仕様を整理する
1. `rg` や `pytest -k ...` で対象範囲を絞る
1. 期待動作を明文化する

### 実装ループ

1. `create-csharp-minimal-api` スキル、または `migration-implementer` に 1 エンドポイント分だけ実装させる
1. `dotnet build` を実行する
1. `curl` で対象エンドポイントだけ確認する

### 検証ループ

1. `validate-migration-parity` スキル、または `migration-validator` で失敗箇所を再現する
1. Python 側の期待動作と比較する
1. 差分の原因を説明する
1. 必要なら implementer に最小修正を依頼する

## 発展課題

- `migration-orchestrator` を起点に、1 つのエンドポイント追加を最後まで完走する
- 既存のプロンプト中心の手順を、agent / skill 中心の手順に自分で書き換える
- `validate-migration-parity` の結果をもとに、検証手順をさらに小さく分割する
- 新しい skill を 1 つ追加し、チームで再利用しやすい形にする

## 成果物のイメージ

このチャレンジを完了すると、単なるチャット履歴ではなく、チームで共有できる AI 活用資産がリポジトリに残ります。

- 共通ルール
- 領域別ルール
- 役割別エージェント
- 再利用可能なスキル
- 実行しやすい CLI レシピ

これにより、このワークショップは「GitHub Copilot のモードを試す教材」から、「実務で再利用できる AI 開発プロセスを設計する教材」へ発展します。