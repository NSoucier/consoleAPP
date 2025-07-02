# First .NET project
Created a console app that has multiple features:
- Asks for your name and generates a password using a Nuget Package.
- Converts times between two GMT time zones for a medicine schedule
- Checks if a given IP is a valid ipv4 format
- Module that acts as a virtual fortune cookie message

To run project:
- dotnet build
- dotnet run

To make changes to published project:
- dotnet build -c Release
- dotnet publish -c Release

To view published project:
- Navigate to .\firstConsole\bin\Release\net8.0\
- run firstConsole.exe