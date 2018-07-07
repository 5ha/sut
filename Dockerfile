FROM shawnseabrook/testrunner:14
WORKDIR /app
COPY Publish/SystemUnderTest .
WORKDIR /tester