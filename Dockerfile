FROM microsoft/dotnet-framework
WORKDIR /Logs
WORKDIR /app
COPY Publish/SystemUnderTest/WebTests .
WORKDIR /tester
COPY Publish/SystemUnderTest/WebTests/lib .