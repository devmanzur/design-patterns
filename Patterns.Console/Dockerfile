FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Patterns.Console/Patterns.Console.csproj", "Patterns.Console/"]
RUN dotnet restore "Patterns.Console/Patterns.Console.csproj"
COPY . .
WORKDIR "/src/Patterns.Console"
RUN dotnet build "Patterns.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Patterns.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Patterns.Console.dll"]
