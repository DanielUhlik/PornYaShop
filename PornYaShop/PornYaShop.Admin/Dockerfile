FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["../PornYaShop.Admin/PornYaShop.Admin.csproj", "../PornYaShop.Admin/"]
RUN dotnet restore "../PornYaShop.Admin/PornYaShop.Admin.csproj"
COPY . .
WORKDIR "/src/../PornYaShop.Admin"
RUN dotnet build "PornYaShop.Admin.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PornYaShop.Admin.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PornYaShop.Admin.dll"]
