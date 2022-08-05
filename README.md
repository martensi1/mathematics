# Mathematics

Aviation mathematics library

Features:

* Calculate distance between two coordinates
* Degree and radian conversion

## Example
Calculate distance between two coordinates:

```csharp
var coordinate1 = new Coordinate(0.0, 0.1);
var coordinate2 = new Coordinate(0.3, 0.7);

double distance = HaversineFormula.CalculateDistance(coordinate1, coordinate2);
```

## Installation
Install with NuGet:

```
dotnet add package PilotAppLibs.Mathematics
```

## License

This repository is licensed with the [MIT](LICENSE) license

## Author

Simon Mårtensson (martensi)

