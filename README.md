# F\# Cloud Native ML API

```bash
$ dotnet new sln -o App
```

```bash
$ dotnet new classlib -lang F# -o src/Library
```

```bash
$ dotnet add src/Library/Library.fsproj package Microsoft.ML
```

```bash
$ dotnet new console -lang F# -o src/App
```

```bash
$ dotnet add src/App/App.fsproj reference src/Library/Library.fsproj
```

```bash
$ dotnet sln add src/App/App.fsproj
```

```bash
$ cd src/App
$ dotnet run HELLO WORLD
```

## AutoML Model Training with ML .NET CLI

```bash
$ mlnet auto-train --task binary-classification --dataset "wikipedia-detox-250-line-data.tsv" --label-column-name "Sentiment" --max-exploration-time 300
```

```bash
$ dotnet add reference ../SampleBinaryClassification/SampleBinaryClassification.Model/
```

```bash
$ dotnet add package Microsoft.ML --version 1.0.0
```

```bash
$ dotnet add package Suave
```

## Troubleshooting

> I can't find `mlnet` when using `zsh`

Add `export PATH=$HOME/.dotnet/tools:$PATH` to your `~/.zshrc` file.

```bash
$ helm install --name fsharp-cloud-native-ml ./chart
```

## Roadmap

- [x] Add Tilt
- [x] Working Model
- [x] Wrap Model in Suave
- [ ] Add Dockerfile
- [ ] Add Helm
- [ ] Add Docs
