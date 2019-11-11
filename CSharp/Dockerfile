FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["leetcodesln_test/leetcodesln_test.csproj", "leetcodesln_test/"]
RUN dotnet restore "leetcodesln_test/leetcodesln_test.csproj"
COPY . .
WORKDIR "/src/leetcodesln_test"
RUN dotnet build "leetcodesln_test.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "leetcodesln_test.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "leetcodesln_test.dll"]
