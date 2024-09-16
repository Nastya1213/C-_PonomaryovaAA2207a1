using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Servers
    {
        private static Servers _instance;
        private static readonly object _lock = new object();
        private HashSet<string> _servers;
        private Servers()
        {
            _servers = new HashSet<string>();
        }
        public static Servers Instance
        {
            get
            {
                // Lazy
                if (_instance == null)
                {
                    lock (_lock)
                    {
                       
                         _instance = new Servers();
                        
                    }
                }
                return _instance;
            }
        }
        public bool AddServer(string address)
        {
            if ((address.StartsWith("http://") || address.StartsWith("https://")) && !_servers.Contains(address))
            {
                _servers.Add(address);
                return true;
            }
            return false;
        }

        public List<string> GetHttpServers()
        {
            return _servers.Where(s => s.StartsWith("http://")).ToList();
        }

        public List<string> GetHttpsServers()
        {
            return _servers.Where(s => s.StartsWith("https://")).ToList();
        }
    }
}



