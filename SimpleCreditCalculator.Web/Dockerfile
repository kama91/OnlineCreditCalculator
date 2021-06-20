#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SimpleCreditCalculator.Web/SimpleCreditCalculator.Web.csproj", "SimpleCreditCalculator.Web/"]
COPY ["SimpleCreditCalculator.Models/SimpleCreditCalculator.Models.csproj", "SimpleCreditCalculator.Models/"]
COPY ["SimpleCreditCalculator.BL/SimpleCreditCalculator.BL.csproj", "SimpleCreditCalculator.BL/"]
RUN dotnet restore "SimpleCreditCalculator.Web/SimpleCreditCalculator.Web.csproj"
COPY . .
WORKDIR "/src/SimpleCreditCalculator.Web"
RUN dotnet build "SimpleCreditCalculator.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleCreditCalculator.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleCreditCalculator.Web.dll"]