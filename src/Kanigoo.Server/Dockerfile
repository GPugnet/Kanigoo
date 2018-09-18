FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 1401
EXPOSE 44323

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Gpusoft.Kanigoo.Server/Gpusoft.Kanigoo.Server.csproj", "Gpusoft.Kanigoo.Server/"]
RUN dotnet restore "Gpusoft.Kanigoo.Server/Gpusoft.Kanigoo.Server.csproj"
COPY . .
WORKDIR "/src/Gpusoft.Kanigoo.Server"
RUN dotnet build "Gpusoft.Kanigoo.Server.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Gpusoft.Kanigoo.Server.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Gpusoft.Kanigoo.Server.dll"]
