using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace Factory
{
    public static class FileHandler
    {
        // Метод для сохранения данных в файл
        public static void SaveToFile(List<Entity> entities, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Entity entity in entities)
                {
                    if (entity is Student student)
                    {
                        writer.WriteLine($"Student,{student.Id},{student.Name},{string.Join(',', student.CourseIds)}");
                    }
                    else if (entity is Teacher teacher)
                    {
                        writer.WriteLine($"Teacher,{teacher.Id},{teacher.Name},{teacher.Experience},{string.Join(',', teacher.CourseIds)}");
                    }
                    else if (entity is Course course)
                    {
                        writer.WriteLine($"Course,{course.Id},{course.Name},{course.TeacherId},{string.Join(',', course.StudentIds)}");
                    }
                }
            }
        }

        // Метод для загрузки данных из файла
        public static List<Entity> LoadFromFile(string filePath)
        {
            List<Entity> entities = new List<Entity>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                entities.Add(EntityFactory.FactoryMethod(line));
            }

            // Восстановление связей между объектами
            foreach (var entity in entities)
            {
                if (entity is Course course)
                {
                    // Восстановление связи с учителем
                    var teacher = entities.FirstOrDefault(e => e.Id == course.TeacherId && e is Teacher);
                    if (teacher != null)
                    {
                        course.TeacherId = teacher.Id;
                    }

                    // Восстановление связи со студентами
                    var studentIds = entities
                        .Where(e => e is Student && course.StudentIds.Contains(e.Id))
                        .Select(e => e.Id)
                        .ToList();

                    // Добавляем студентов в существующий список
                    course.StudentIds.AddRange(studentIds);
                }
            }

            return entities;
        }

    }
}
