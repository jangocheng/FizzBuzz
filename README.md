# FizzBuzz
An assignment for a job application. Written in C# using Dotnet Core for Linux


## Usage
* Download the project using `git clone https://github.com/ptrkrlsrd/FizzBuzz`
* Run `dotnet restore`
* Run the application using `dotnet run -p cli/cli.csproj`
* Test the application using `dotnet test FizzBuzz-Tests/FizzBuzz-Tests.csproj`


## Features
### A pre-commit hook which tests the code before commiting.
```
if dotnet test FizzBuzz-Tests/FizzBuzz-Tests.csproj | egrep --quiet 'Failed: 0'; then
  echo Test passed
else
  echo Test failed
  exit 1
ff
```
