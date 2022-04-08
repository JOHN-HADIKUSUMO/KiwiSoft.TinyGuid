# KiwiSoft.TinyGuid
#### This nuget package is meant to be used to generate unique id. The following code below is the simplest implementation of this package.
```C#
  using KiwiSoft.TinyGuid;
  class Program
  {
    static void Main(string[] args)
    {
      GuidGenerator guidGenerator = new GuidGenerator();
      string uuid = guidGenerator.UUID();
      Console.WriteLine(uuid);
      Console.ReadLine();
    }
  }
```

the output would look like this

![alt text](https://github.com/JOHN-HADIKUSUMO/KiwiSoft.TinyGuid/blob/main/Capture.PNG)

The output may consist of the combination alphanumeric plus several special characters like "-", "_" or ".". If you only want alphanumeric on the output
you must set the parameter value to "true" on the UUID method as seen below.

```C#
  using KiwiSoft.TinyGuid;
  class Program
  {
    static void Main(string[] args)
    {
      GuidGenerator guidGenerator = new GuidGenerator();
      string uuid = guidGenerator.UUID(true);
      Console.WriteLine(uuid);
      Console.ReadLine();
    }
  }
```
