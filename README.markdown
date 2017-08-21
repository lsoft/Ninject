# Ninject [![NuGet Version](http://img.shields.io/nuget/v/Ninject.svg?style=flat)](https://www.nuget.org/packages/Ninject/) 
Ninject is a lightning-fast, ultra-lightweight dependency injector for .NET applications. It helps you split your
application into a collection of loosely-coupled, highly-cohesive pieces, and then glue them back together in a
flexible manner. By using Ninject to support your software's architecture, your code will become easier to write,
reuse, test, and modify.

...


This fork is based on Ninject 3.2.3 and is intended for .Net Core 2. All unit tests are green except for one.
For additonal information please refer https://github.com/ninject/Ninject.Extensions.Factory/issues/35

Please note: I think it's risky to use it in a production environment.


To compile it in Visual Studio Code please
1) run VS Code
2) open folder ninject/src in VS Code
3) press Ctrl+` to open terminal
4) execute

dotnet restore Ninject

dotnet restore Ninject.Test

dotnet build Ninject

dotnet build Ninject.Test

dotnet test .\Ninject.Test\Ninject.Test.csproj -c release

(release testing is required because of that JIT feature: https://github.com/dotnet/coreclr/issues/12847)

(for Russians: console encoding can be changed by this command: [Console]::OutputEncoding = [System.Text.Encoding]::UTF8 )


## License
Ninject is intended to be used in both open-source and commercial environments. To allow its use in as many
situations as possible, Ninject is dual-licensed. You may choose to use Ninject under either the Apache License,
Version 2.0, or the Microsoft Public License (Ms-PL). These licenses are essentially identical, but you are
encouraged to evaluate both to determine which best fits your intended use.

Refer to [LICENSE.txt](https://github.com/ninject/ninject/blob/master/LICENSE.txt) for detailed information.