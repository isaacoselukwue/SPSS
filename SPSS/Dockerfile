FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["SPSS/SPSS.csproj", "./"]
RUN dotnet restore "./SPSS.csproj"

COPY . .
RUN dotnet publish "SPSS/SPSS.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html

RUN rm -rf ./*

COPY --from=build /app/publish/wwwroot .

EXPOSE 80
ENTRYPOINT ["nginx", "-g", "daemon off;"]