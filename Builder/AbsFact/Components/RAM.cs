using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFact.Components
{
    public class RAM
    {
        public string Capacity { get; set; }
        public RAM(string capacity)
        {
            Capacity = capacity;
        }
    }
}
