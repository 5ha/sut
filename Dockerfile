FROM shawnseabrook/testrunner:18
WORKDIR /Logs
WORKDIR /app
COPY Publish/SystemUnderTest .
WORKDIR /tester