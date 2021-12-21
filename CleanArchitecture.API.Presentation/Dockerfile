#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CleanArchitecture.API.Presentation/CleanArchitecture.API.Presentation.csproj", "CleanArchitecture.API.Presentation/"]
RUN dotnet restore "CleanArchitecture.API.Presentation/CleanArchitecture.API.Presentation.csproj"
COPY . .
WORKDIR "/src/CleanArchitecture.API.Presentation"
RUN dotnet build "CleanArchitecture.API.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CleanArchitecture.API.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CleanArchitecture.API.Presentation.dll"]