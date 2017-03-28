FROM microsoft/dotnet:latest
ENV PORT=8080
RUN mkdir app
WORKDIR app
COPY . .
RUN dotnet restore
RUN dotnet build
ENTRYPOINT dotnet run \
             --environment="Production" \
             --server.urls http://0.0.0.0:$PORT
