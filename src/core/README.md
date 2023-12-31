# Dime.Ext

.NET classes for Sencha ExtJS.

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

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)