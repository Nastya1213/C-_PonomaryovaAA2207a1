using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerGame cyberpunk = new ComputerGame(
                "Cyberpunk 2077",
                PegiAgeRating.P18,
                100, // Бюджет в миллионах долларов
                8192, // Видеопамять в МБ
                70, // Необходимое место на диске в ГБ
                16, // Необходимая оперативная память в ГБ
                8, // Количество ядер
                3.5 // Частота процессора в ГГц
            );
            PCGame pcGame = new ComputerGameAdapter(cyberpunk);
            Console.WriteLine($"Название игры: {pcGame.getTitle()}");
            Console.WriteLine($"Минимальный возраст: {pcGame.getPegiAllowedAge()}");
            Console.WriteLine($"Игра TripleA: {pcGame.isTripleAGame()}");
            Requirements requirements = pcGame.getRequirements();
            Console.WriteLine($"Требования к системе: GPU {requirements.getGpuGb()} GB, HDD {requirements.getHDDGb()} GB, RAM {requirements.getRAMGb()} GB, CPU {requirements.getCpuGhz()} GHz, Ядер: {requirements.getCoresNum()}");
            ComputerGame hollowKnight = new ComputerGame(
                "Hollow Knight",
                PegiAgeRating.P7,
                20,  // Бюджет в миллионах долларов (меньше 50)
                2048, // Видеопамять в МБ
                9,   // Необходимое место на диске в ГБ
                4,   // Необходимая оперативная память в ГБ
                2,   // Количество ядер
                2.5  // Частота процессора в ГГц
            );
            PCGame pcGame2 = new ComputerGameAdapter(hollowKnight);
            Console.WriteLine($"Название игры: {pcGame.getTitle()}");
            Console.WriteLine($"Минимальный возраст: {pcGame.getPegiAllowedAge()}");
            Console.WriteLine($"Игра TripleA: {pcGame.isTripleAGame()}");
            Requirements requirements2 = pcGame.getRequirements();
            Console.WriteLine($"Требования к системе: GPU {requirements.getGpuGb()} GB, HDD {requirements.getHDDGb()} GB, RAM {requirements.getRAMGb()} GB, CPU {requirements.getCpuGhz()} GHz, Ядер: {requirements.getCoresNum()}");
        }
    }
}
