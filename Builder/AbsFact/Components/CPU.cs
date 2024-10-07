using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFact.Components
{
    public class CPU
    {
        public string Model { get; set; }
        public CPU(string model)
        {
            Model = model;
        }
    }
}
