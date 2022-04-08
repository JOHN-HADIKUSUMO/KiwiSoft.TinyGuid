# KiwiSoft.TinyGuid
#### This nuget package is meant to be used to generate unique id. 
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
