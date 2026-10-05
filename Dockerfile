# =========================
# BUILD
# =========================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY ["API docker Test/API docker Test.csproj", "API docker Test/"]

RUN dotnet restore "API docker Test/API docker Test.csproj"

COPY . .

WORKDIR "/src/API docker Test"

RUN dotnet publish "API docker Test.csproj" \
    -c Release \
    -o /app/publish \
    --no-restore


# =========================
# RUNTIME
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "API docker Test.dll"]
