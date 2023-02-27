FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TestGrpc.ConsoleApp/TestGrpc.ConsoleApp.csproj", "TestGrpc.ConsoleApp/"]
RUN dotnet restore "TestGrpc.ConsoleApp/TestGrpc.ConsoleApp.csproj"
COPY . .
WORKDIR "/src/TestGrpc.ConsoleApp"
RUN dotnet build "TestGrpc.ConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestGrpc.ConsoleApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestGrpc.ConsoleApp.dll"]
