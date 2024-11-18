using System;
using System.Collections.Generic;
using System.Threading;
namespace Proxy{
    // Прокси (Proxy), который контролирует доступ к RealSubject
public class Proxy : ISubject
{
    private readonly RealSubject _realSubject;
    private readonly Dictionary<string, string> _cache;
    private readonly Dictionary<string, string> _accessControl;
    private readonly TimeSpan _cacheExpiry;
    private readonly DateTime _cacheTimestamp;

    public Proxy(RealSubject realSubject)
    {
        _realSubject = realSubject;
        _cache = new Dictionary<string, string>();
        _accessControl = new Dictionary<string, string>
        {
            { "admin", "full_access" },
            { "guest", "limited_access" }
        };
        _cacheExpiry = TimeSpan.FromSeconds(5); // Кэшируем на 5 секунд
        _cacheTimestamp = DateTime.Now;
    }

    public string Request(string request)
    {
        // Проверка прав доступа
        if (!CheckAccess("admin"))
        {
            return "Access Denied: You do not have permission to perform this action.";
        }

        // Проверка кэша
        if (_cache.ContainsKey(request) && DateTime.Now - _cacheTimestamp < _cacheExpiry)
        {
            Console.WriteLine("Proxy: Возвращаю ответ из кэша.");
            return _cache[request];
        }

        Console.WriteLine("Proxy: Делаю реальный запрос.");
        // Если в кэше нет или срок действия кэша истек, вызываем RealSubject
        string result = _realSubject.Request(request);

        // Кэшируем результат
        _cache[request] = result;

        return result;
    }

    // Проверка прав доступа
    private bool CheckAccess(string userRole)
    {
        return _accessControl.ContainsKey(userRole) && _accessControl[userRole] == "full_access";
    }
}
}