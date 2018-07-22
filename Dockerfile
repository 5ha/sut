FROM shawnseabrook/testrunner:25
WORKDIR /Logs
WORKDIR /app
COPY Publish/SystemUnderTest .
WORKDIR /tester