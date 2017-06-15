# astro-data-self-hosting-service
uses C#.NET, Structuremap, Servicestack, Topshelf, and Entity Framework
<br/>
This is a simple micro-service which assumes a MS-SQL backend. It will create an "AstroData" datase and populate it with some planet data.
When the console app runs it will self host. The service can be tested using a ping endpoint, current hard coded to http://localhost:3334/astro-data/ping.json
The planet data can be retrieved by accessing the endpoint http://localhost:3334/astro-data/planets.json

