FROM shawnseabrook/testrunner:35
WORKDIR /Tmp
@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"
choco install googlechrome
WORKDIR /Logs
WORKDIR /app
COPY Publish/SystemUnderTest/WebTests .
WORKDIR /tester