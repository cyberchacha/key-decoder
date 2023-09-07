using ShareInvest.Identifies;
using System.Runtime.Versioning;

[assembly: SupportedOSPlatform("windows8.0")]

if (KeyDecoder.ProductKeyFromRegistry is string key)
{
    Console.WriteLine(key);

    Console.ReadLine();
}