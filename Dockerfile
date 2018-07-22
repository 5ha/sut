FROM shawnseabrook/testrunner:27
WORKDIR /Logs
WORKDIR /app
COPY Publish/SystemUnderTest .
WORKDIR /tester