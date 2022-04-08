using System.Net.NetworkInformation;

string addr = "";
foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
{
    if (n.OperationalStatus == OperationalStatus.Up)
    {
        addr += n.GetPhysicalAddress().ToString();
        Console.WriteLine(addr);
        break;
    }
}

Console.ReadLine();
