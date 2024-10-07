using AbsFact.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFact.Models
{
    public class Computer
    {
        public CPU Cpu { get; set; }
        public Motherboard Motherboard { get; set; }
        public RAM Ram { get; set; }
        public Storage Storage { get; set; }
        public GPU Gpu { get; set; }

        public override string ToString()
        {
            return $"CPU: {Cpu?.Model}, Motherboard: {Motherboard?.Model}, RAM: {Ram?.Capacity}, Storage: {Storage?.Type}, GPU: {Gpu?.Model}";
        }
    }
}
