FROM microsoft/dotnet-framework
WORKDIR /app
COPY Publish/SystemUnderTest .
WORKDIR /app/lib