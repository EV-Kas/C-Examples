FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["StaticAndThreads/StaticAndThreads.csproj", "StaticAndThreads/"]
RUN dotnet restore "StaticAndThreads/StaticAndThreads.csproj"
COPY . .
WORKDIR "/src/StaticAndThreads"
RUN dotnet build "StaticAndThreads.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StaticAndThreads.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StaticAndThreads.dll"]
