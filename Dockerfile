FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["DevOpsBP.csproj", ""]
RUN dotnet restore "DevOpsBP.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "DevOpsBP.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DevOpsBP.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DevOpsBP.dll"]