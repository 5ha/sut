FROM shawnseabrook/testrunner:17
WORKDIR /Logs
WORKDIR /app
COPY Publish/SystemUnderTest .
WORKDIR /tester