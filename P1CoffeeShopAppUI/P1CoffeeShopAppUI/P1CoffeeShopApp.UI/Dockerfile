
#FROM <repo>/<user>/<image>:<tag>(defaults to "latest")
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

#COPY <relative path from Dockerfile to target files> <target location in image>
COPY bin/Release/net6.0/publish/ P1CoffeeShopApp.UI/

# #Change the images current working directory
WORKDIR /P1CoffeeShopApp.UI

# Copy the contents of the folder where the Dockerfile lives, into the image
COPY . .

RUN dotnet publish -c Release

FROM mcr.microsoft.com/dotnet/aspnet:6.0 
WORKDIR /P1CoffeeShopApp

COPY  --from=build /P1CoffeeShopApp.UI/bin/Release/net6.0/publish/ .

ENTRYPOINT ["dotnet", "P1CoffeeShopApp.UI.dll"]

#Entrypoint sets the container to be an executable, and specifies
#what to run on startup.