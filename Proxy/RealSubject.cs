using System;
using System.Collections.Generic;
using System.Threading;
namespace Proxy{
    // Реальный субъект (RealSubject), который выполняет реальную работу
public class RealSubject : ISubject
{
    public string Request(string request)
    {
        Console.WriteLine("RealSubject: Обрабатываю запрос: " + request);
        // Симуляция длительной операции
        Thread.Sleep(1000);
        return "Ответ на запрос: " + request;
    }
}
}