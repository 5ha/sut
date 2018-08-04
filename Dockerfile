FROM shawnseabrook/testrunner:35
WORKDIR /Logs
WORKDIR /app
COPY Publish/SystemUnderTest/WebTests .
WORKDIR /tester