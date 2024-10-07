using AbsFact.Builders;

namespace AbsFact
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerBuilder builder = new ComputerBuilder();
            var myComputer = builder
                .SetCPU("Intel Core i5")
                .SetMotherboard("ASUS ROG Strix")
                .SetRAM("16GB")
                .SetStorage("SSD 1TB")
                .SetGPU("NVIDIA RTX 3080")
                .Build();

            Console.WriteLine("Собранный компьютер:");
            Console.WriteLine(myComputer);
        }
    }
}
