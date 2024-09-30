using Factory;
using System;
using System.Collections.Generic;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entity> entities = new List<Entity>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        entities.Add(EntityFactory.FactoryMethod($"Student,{i},StudentName{i}"));
                        break;
                    case 1:
                        entities.Add(EntityFactory.FactoryMethod($"Teacher,{i},TeacherName{i},{rnd.Next(1, 30)}"));
                        break;
                    case 2:
                        entities.Add(EntityFactory.FactoryMethod($"Course,{i},CourseName{i},{rnd.Next(1, 10)}"));
                        break;
                }
            }

            foreach (Entity entity in entities)
            {
                Console.WriteLine(entity.GetType().Name + " - " + entity.Name);
            }

            // Сохранение данных в файл
            FileHandler.SaveToFile(entities, "entities.txt");
            Console.WriteLine("Данные сохранены в файл.");

            // Загрузка данных из файла
            var loadedEntities = FileHandler.LoadFromFile("entities.txt");
            Console.WriteLine("Данные загружены из файла:");

            foreach (Entity entity in loadedEntities)
            {
                Console.WriteLine(entity.GetType().Name + " - " + entity.Name);
            }
            // Для проверки можно очистить/удалить .txt файл в bin/debug
        }
    }
}