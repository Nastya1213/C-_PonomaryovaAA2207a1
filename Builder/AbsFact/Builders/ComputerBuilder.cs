using AbsFact.Components;
using AbsFact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFact.Builders
{
    public class ComputerBuilder
    {
        private Computer _computer = new Computer();

        public ComputerBuilder SetCPU(string model)
        {
            _computer.Cpu = new CPU(model);
            return this;
        }

        public ComputerBuilder SetMotherboard(string model)
        {
            _computer.Motherboard = new Motherboard(model);
            return this;
        }

        public ComputerBuilder SetRAM(string capacity)
        {
            _computer.Ram = new RAM(capacity);
            return this;
        }

        public ComputerBuilder SetStorage(string type)
        {
            _computer.Storage = new Storage(type);
            return this;
        }

        public ComputerBuilder SetGPU(string model)
        {
            _computer.Gpu = new GPU(model);
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
