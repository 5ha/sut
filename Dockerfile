FROM shawnseabrook/testrunner:31
WORKDIR /Logs
WORKDIR /app
COPY Publish/SystemUnderTest/WebTests .
WORKDIR /tester