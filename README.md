# R6Stats-Sharp
An C# API Client for R6Stats API

<a href="https://ci.appveyor.com/project/CenkErgen/r6stats-sharp">
<img alt="AppVeyor" src="https://img.shields.io/appveyor/build/CenkErgen/r6stats-sharp?logo=appveyor&logoColor=white&style=for-the-badge">
</a>
<a href="https://www.nuget.org/packages/R6Stats-Sharp/">
<img alt="Nuget" src="https://img.shields.io/nuget/dt/R6Stats-Sharp?color=blue&logo=nuget&logoColor=white&style=for-the-badge">
</a>
<a href="https://www.nuget.org/packages/R6Stats-Sharp/">
<img alt="Nuget" src="https://img.shields.io/nuget/v/R6Stats-Sharp?color=pink&logo=nuget&logoColor=white&style=for-the-badge">
</a>

---
## Getting Started
To use this library you will need an API Key. You can learn more about it [here.](https://github.com/R6Stats/r6stats-node#api-key)
```csharp
var config = new R6StatsClientConfig("<api key>");
var client = new R6StatsClient(config);
```
which, then can be used to make the API Requests. Every API Request returns an `ApiResponse` object which contains the status of the response and the error message, if there is any, and the data payload that is the result of the said request.

To learn more about the library you can check out the [wiki](https://github.com/Cenngo/R6Stats-Sharp/wiki).
You can access the reference documentation from [here](https://cenngo.github.io/R6Stats-Sharp/api/R6Stats.html).
