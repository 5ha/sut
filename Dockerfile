FROM shawnseabrook/testrunner:17
WORKDIR /app
COPY Publish/SystemUnderTest .
WORKDIR /tester