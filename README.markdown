# Ninject [![NuGet Version](http://img.shields.io/nuget/v/Ninject.svg?style=flat)](https://www.nuget.org/packages/Ninject/) 
Ninject is a lightning-fast, ultra-lightweight dependency injector for .NET applications. It helps you split your
application into a collection of loosely-coupled, highly-cohesive pieces, and then glue them back together in a
flexible manner. By using Ninject to support your software's architecture, your code will become easier to write,
reuse, test, and modify.

...


This fork is based on Ninject 3.2.3 and is intended for .Net Core 1. All unit tests work fine except only one.
For additonal information please refer https://github.com/ninject/Ninject.Extensions.Factory/issues/35

Please note: I think it's risky to use it in a production environment.


To compile it in Visual Studio Code please
1) run VS Code
2) open folder ninject/src in VS Code
3) press Ctrl+` to open terminal
4) execute
dotnet build Ninject
dotnet build Ninject.Test
dotnet test .\Ninject.Test\Ninject.Test.csproj
