FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR mvcDocker

EXPOSE 80
EXPOSE 5022

COPY ./*.csproj ./
RUN dotnet restore 

COPY . . 
RUN dotnet publish -c Release -o Publi

FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /mvcDocker
COPY --from=build /mvcDocker/Publi .
ENTRYPOINT ["dotnet","Login.dll"]