# F\# Cloud Native ML

A toolbox for creating cloud native ML APIs for F#.

## Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download)
2. Docker
3. Kubernetes

## Creating the Code

- [Create F# Project](https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-command-line)
- [ML .NET CLI](https://dotnet.microsoft.com/learn/machinelearning-ai/ml-dotnet-get-started-tutorial/intro)

## AutoML Model Training with ML .NET CLI

```bash
$ mlnet auto-train --task binary-classification --dataset "wikipedia-detox-250-line-data.tsv" --label-column-name "Sentiment" --max-exploration-time 300
```

```bash
$ dotnet add reference ../SampleBinaryClassification/SampleBinaryClassification.Model/
```

## Troubleshooting

> I can't find `mlnet` when using `zsh`

Add `export PATH=$HOME/.dotnet/tools:$PATH` to your `~/.zshrc` file.

```bash
$ helm install --name fsharp-cloud-native-ml ./chart
```

## Roadmap

- [ ] Add Helm Ingress
- [ ] Add Docs
