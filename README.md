# R6Stats-Sharp
C# API Client for R6Stats API

<a href="https://ci.appveyor.com/project/CenkErgen/r6stats-sharp">
<img alt="AppVeyor" src="https://img.shields.io/appveyor/build/CenkErgen/r6stats-sharp?logo=appveyor&logoColor=white&style=for-the-badge">
</a>
<a href="https://www.nuget.org/packages/R6Stats-Sharp/">
<img alt="Nuget" src="https://img.shields.io/nuget/dt/R6Stats-Sharp?color=blue&logo=nuget&logoColor=white&style=for-the-badge">
</a?

---
## Getting Started
To use this library, first you need to create an instance of the REST API Client.
```csharp
var config = new R6StatsClientConfig("<api key>");
var client = new R6StatsClient(config);
```
which, then can be used to make the API Requests. Every API Request returns an `ApiResponse` object which contains the status of the response and the error message, if there is any, and the data payload that is the result of the said request.

There are 6 kinds of essential request that can be made: `generic`, `seasonal`, `operators`, `weapons`, `weapon-categories`, `leaderboard`.
- Generic: General profile information of a player. Covers the basic stats in almost every data type.
- Seasonal: Covers detailed ranked playlist informations about all of the seasons a player took place in.
- Operators: Contains detailed information about the players operator stats.
- Weapons: Contains datiled information which is specific to every gun.
- Weapon-Categories: Contains the information found in `Weapons` request type, but the stats are grouped by the weapon categories.
- Leaderboard: I think this one is pretty self explanatory. 

Every request type can be made by their respective method.
```csharp
var generic = await client.GetGenericStats("<username>", Platform.PC);
var seasonal = await client.GetSeasonalStats("<username>", Platform.PC);
```
