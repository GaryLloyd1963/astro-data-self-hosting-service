# astro-data-self-hosting-service
Uses C#.NET, Structuremap, Servicestack, Topshelf, and Entity Framework
<br/>
This is a simple micro-service which assumes a MS-SQL backend.<br/>
It will create an "AstroData" datase and populate it with some planet data.<br/>
When the console app runs it will self host.<br/>
The service can be tested using a ping endpoint (returns 200), currently hard coded to http://localhost:3334/astro-data/ping.json<br/>
The planet data can be retrieved by accessing the endpoint http://localhost:3334/astro-data/planets.json<br/>

