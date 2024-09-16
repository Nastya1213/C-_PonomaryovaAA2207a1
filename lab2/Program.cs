using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2;


// Пример использования
class Program
{
    static void Main()
    {
        Servers servers = Servers.Instance;
        Console.WriteLine("Lazy");
       Console.WriteLine(servers.AddServer("http://example.com")); // True
        Console.WriteLine(servers.AddServer("https://example.com")); // True
        Console.WriteLine(servers.AddServer("http://example.com")); // False (дубликат)
        Console.WriteLine(servers.AddServer("ftp://example.com")); // False (не начинается с http или https)
        Console.WriteLine(string.Join(", ", servers.GetHttpServers()));  // http://example.com
        Console.WriteLine(string.Join(", ", servers.GetHttpsServers())); // https://example.com
        Console.WriteLine("Eager");
       EagerServers servers2 = EagerServers.Instance;
        Console.WriteLine(servers2.AddServer("http://example.com")); // True
        Console.WriteLine(servers2.AddServer("https://example.com")); // True
        Console.WriteLine(servers2.AddServer("http://example.com")); // False (дубликат)
        Console.WriteLine(servers2.AddServer("ftp://example.com")); // False (не начинается с http или https)
        Console.WriteLine(string.Join(", ", servers2.GetHttpServers()));  // http://example.com
        Console.WriteLine(string.Join(", ", servers2.GetHttpsServers())); // https://example.com


    }
}