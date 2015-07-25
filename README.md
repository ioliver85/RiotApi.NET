<img src="https://s3-us-west-1.amazonaws.com/riot-api/img/riot-api-landing.png" alt="riot"/>
<img src="http://www.brandsoftheworld.com/sites/default/files/styles/logo-thumbnail/public/052011/microsoft_.net_.png?itok=yeSwxY-i" alt=".net"/>
# RiotApi.NET
> (WORK IN PROGRESS)


This is a .net Api for Riot Games League of Legends written in C#. The goal of this ptoject is to provide a higher 
level of interaction with the Riot's API Rest service, json responses are deserialized to objects and all methods of the
service are called via an Interface with all supported methods as documented by Riot.

In other words this project is a C# wrapper client that can be used within any kind of .net application or any other application using .net mono framework.

#How to use
The usage of the RiotApi.Net is a piece of cake! In less than three lines of code you can retrieve any data
from Riot's services. 
For instance you can fetch all free to play champions and print them to screen as you can see in the following example.

```cs
//initialize Champion api with your riot api key
IChampion championApi = new Champion("your api key here");
//retrieve all current free to play champions
var championList = championApi.RetrieveAllChampions(RiotApiConfig.Regions.NA, freeToPlay:true);
//just pring the number of free to play champions
Console.WriteLine($"There are {championList.Champions.Count()} free to play champions to play with!");
```

```
response => There are 17 free to play champions to play with!
```

The goal of this project is to provide .net application developers with a high level tool to use
Riot games' API in their apps. I hope you will like it! Please feel free to contribute.

# RiotApi.NET web ASP.NET MVC User Interface 
> (WORK IN PROGRESS)

# Third party libraries used
* [Newtonsoft.Json](http://www.newtonsoft.com/json)
* [Autofac](http://autofac.org/)
* [NLog](http://nlog-project.org/)
* [Bootstrap](http://getbootstrap.com/)
* [NUnit](http://www.nunit.org/)