# Dime.Ext

[![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/Ext%20-%20MAIN%20-%20CI?branchName=master)](https://dev.azure.com/dimenicsbe/Utilities/_build/latest?definitionId=66&branchName=master)

## Introduction

.NET classes for Sencha ExtJS.

## Getting Started

- You must have Visual Studio 2019 Community or higher.
- The dotnet cli is also highly recommended.

## About this project

.NET classes for Sencha ExtJS filters and sorters.

## Build and Test

- Run dotnet restore
- Run dotnet build
- Run dotnet test

## Installation

Use the package manager NuGet to install Dime.ExtJs:

- dotnet cli: `dotnet add package Dime.ExtJs`
- Package manager: `Install-Package Dime.ExtJs`

## Usage

``` csharp
using Dime.ExtJs;

public IEnumerable<MyData> Get(string filterString)
{
    Filter filterObject = JsonConvert.DeserializeObject<Filter>(filterString);
}
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
Please make sure to update tests as appropriate.

## License

MIT