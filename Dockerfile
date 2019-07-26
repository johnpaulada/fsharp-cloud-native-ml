FROM fsharp:netcore
COPY ./App /app
WORKDIR /app/src/App
CMD ["dotnet", "run"]