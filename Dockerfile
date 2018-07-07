FROM shawnseabrook/testrunner:15
WORKDIR /app
COPY Publish/SystemUnderTest .
WORKDIR /tester