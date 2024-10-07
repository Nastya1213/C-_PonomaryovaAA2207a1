using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFact.Components
{
    public class Storage
    {
        public string Type { get; set; }
        public Storage(string type)
        {
            Type = type;
        }
    }
}
