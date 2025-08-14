//Create directory
mkdir 01_FirstSolution
cd 01_FirstSolution

//Create the solution
dotnet new sln --name FirstSolution

//Create the project (as a library) to hold the code to be tested
dotnet new classlib -o FirstLib

//Add the library to the solution
dotnet sln add FirstLib

//Create the xUnit test project
dotnet new xunit -o FirstTest

//Add the test project to the solution
dotnet sln add FirstTest
