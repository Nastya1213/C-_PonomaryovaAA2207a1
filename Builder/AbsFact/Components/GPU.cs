using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFact.Components
{
    public class GPU
    {
        public string Model { get; set; }
        public GPU(string model)
        {
            Model = model;
        }
    }
}
