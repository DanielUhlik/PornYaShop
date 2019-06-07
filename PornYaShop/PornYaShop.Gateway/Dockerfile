FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["PornYaShop.Gateway/PornYaShop.Gateway.csproj", "PornYaShop.Gateway/"]
RUN dotnet restore "PornYaShop.Gateway/PornYaShop.Gateway.csproj"
COPY . .
WORKDIR "/src/PornYaShop.Gateway"
RUN dotnet build "PornYaShop.Gateway.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PornYaShop.Gateway.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PornYaShop.Gateway.dll"]
