using System;
using System.Collections.Generic;
using System.Threading;
namespace Proxy{
    public class Program
{
    public static void Main(string[] args)
    {
        RealSubject realSubject = new RealSubject();
        Proxy proxy = new Proxy(realSubject);
        Console.WriteLine(proxy.Request("Запрос 1"));
        Console.WriteLine(proxy.Request("Запрос 1"));
        Console.WriteLine(proxy.Request("Запрос 2"));

        // После истечения времени кэша, запрос снова будет направлен к RealSubject
        Thread.Sleep(6000); // Ждем больше 5 секунд (время истечения срока действия кэша)
        Console.WriteLine(proxy.Request("Запрос 1"));
    }
}
}