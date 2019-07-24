// Learn more about F# at http://fsharp.org

open System
open SampleBinaryClassification.Model.DataModels
open Microsoft.ML

[<EntryPoint>]
let main argv =
    let ctx = MLContext()
    let model, modelInputSchema = ctx.Model.Load("../SampleBinaryClassification/SampleBinaryClassification.Model/MLModel.zip")
    let predEngine = ctx.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model)
    let input = ModelInput()
    input.SentimentText <- "RFC Response"
    let result = predEngine.Predict(input)
    let display = 
      match result.Prediction with
        | true -> "Toxic"
        | false -> "Not Toxic"
    printfn "%s" display
    0
