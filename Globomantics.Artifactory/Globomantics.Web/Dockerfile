#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["Globomantics.Web/Globomantics.Web.csproj", "Globomantics.Web/"]
COPY ["Globomantics.Communication/Globomantics.Communication.csproj", "Globomantics.Communication/"]
RUN dotnet restore "Globomantics.Web/Globomantics.Web.csproj"
COPY . .
WORKDIR "/src/Globomantics.Web"
RUN dotnet build "Globomantics.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Globomantics.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Globomantics.Web.dll"]