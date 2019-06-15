# IPifyAPI
Unofficial IPify API for C# that allows you to get the external IPv4 &amp; IPv6 easily.

## Simple to use
Using IPifyAPI for C# is simple and easy to use.  
Here is an example:  
```csharp
// Create the class instance  
IPifyAPI ipAPI = new IPifyAPI();  
  
// Simply get the IPv4 or IPv6 via <instanceName>.IPv4  
Console.WriteLine("Current External IPv4: {0}", ipAPI.IPv4);  
Console.WriteLine("Current External IPv6: {0}", ipAPI.IPv6);  
```
### Files
You can reach to the source code from the [src](src) folder.  
Also included an ready to use compiled [IPifyAPI.dll](IPifyAPI.dll) file in the master folder.
