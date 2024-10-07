using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFact.Components
{
    public class Motherboard
    {
        public string Model { get; set; }
        public Motherboard(string model)
        {
            Model = model;
        }
    }
}
