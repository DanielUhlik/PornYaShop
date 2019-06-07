FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["PornYaShop.Products/PornYaShop.Products.csproj", "PornYaShop.Products/"]
COPY ["PornYaShop.DataContext/PornYaShop.DataContext.csproj", "PornYaShop.DataContext/"]
COPY ["PornYaShop.Shared/PornYaShop.Shared.csproj", "PornYaShop.Shared/"]
RUN dotnet restore "PornYaShop.Products/PornYaShop.Products.csproj"
COPY . .
WORKDIR "/src/PornYaShop.Products"
RUN dotnet build "PornYaShop.Products.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PornYaShop.Products.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PornYaShop.Products.dll"]
