// Learn more about F# at http://fsharp.org

open System
open SampleBinaryClassification.Model.DataModels
open Microsoft.ML
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful

let ctx = MLContext()
let model, modelInputSchema = ctx.Model.Load("../SampleBinaryClassification/SampleBinaryClassification.Model/MLModel.zip")
let predEngine = ctx.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model)

let predictToxicity s =
  let input = ModelInput()
  input.SentimentText <- s
  let result = predEngine.Predict(input)
  let display = 
    match result.Prediction with
      | true -> "Toxic"
      | false -> "Not Toxic"
  display

let getQueryParam(m) =
  match m with
    | Choice1Of2 p -> p
    | _ -> ""

let handleToxicity =
  request(fun r ->
    OK (predictToxicity(getQueryParam(r.queryParam("q"))))
  )

let app =
  choose
    [ GET >=> choose
        [ path "/toxicity" >=> handleToxicity ]
    ]

[<EntryPoint>]
let main argv =
    startWebServer defaultConfig app
    0
