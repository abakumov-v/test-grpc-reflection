FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TestGrpcReflection/TestGrpcReflection.csproj", "TestGrpcReflection/"]
RUN dotnet restore "TestGrpcReflection/TestGrpcReflection.csproj"
COPY . .
WORKDIR "/src/TestGrpcReflection"
RUN dotnet build "TestGrpcReflection.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestGrpcReflection.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestGrpcReflection.dll"]
