using System;
using System.Collections.Generic;
using System.Linq;

public class EagerServers
{
    private static readonly EagerServers _instance = new EagerServers();

    private HashSet<string> _servers;
    private readonly object _lock = new object();

    private EagerServers()
    {
        _servers = new HashSet<string>();
    }

    public static EagerServers Instance => _instance;

    public bool AddServer(string serverAddress)
    {
        if (string.IsNullOrWhiteSpace(serverAddress) ||
            !(serverAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
              serverAddress.StartsWith("https://", StringComparison.OrdinalIgnoreCase)))
        {
            return false;
        }

        lock (_lock)
        {
            return _servers.Add(serverAddress);
        }
    }

    public IEnumerable<string> GetHttpServers()
    {
        lock (_lock)
        {
            return _servers.Where(s => s.StartsWith("http://", StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }

    public IEnumerable<string> GetHttpsServers()
    {
        lock (_lock)
        {
            return _servers.Where(s => s.StartsWith("https://", StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
