# ShopperTrakAPI_CSharp
 Work in progress

This version of the API includes the following calls:

- [ ] Hierarchy Call
- [ ] Basic KPIs Call
- [x] Hourly Performance Call
- [ ] Power Hours Call


### Hourly Performance Call
#### Returns daily performance broken down by hour for one day specified

###### Example Call:
```csharp
//Set up new API credentials (username and password supplied by ShopperTrak)
Credentials credentials = new Credentials(username, password);

HourlyPerformanceCall call = new HourlyPerformanceCall(trafficDate, hierarchyID);
HourlyPerformanceResponse response = call.Execute(credentials);
//Response will hold all info including a list of Hours, which hold the data for that hour.
```
