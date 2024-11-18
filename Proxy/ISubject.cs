using System;
using System.Collections.Generic;
using System.Threading;
namespace Proxy{
// Интерфейс Subject
public interface ISubject
{
    string Request(string request);
}
}