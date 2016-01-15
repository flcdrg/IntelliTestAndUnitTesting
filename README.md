# IntelliTestAndUnitTesting
Sample code from my "IntelliTest and other .NET unit testing tools" talk

To use this, you'll need to create a file under the IntelliTestAndUnitTesting project folder named `App.private.config`. The contents should look like this:

```
<?xml version="1.0" encoding="utf-8" ?>
<appSettings>
  <add key="bingMapsKey" value="XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx"/>
</appSettings>
```
Replace XXXX with a valid Bing Maps key.

Also edit app.config and update the connection string to point to an instance of the AdventureWorks database.
