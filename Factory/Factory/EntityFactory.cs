using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace Factory
{
    public abstract class EntityFactory
    {
        // Фабричный метод для создания объектов на основе строки
        public static Entity FactoryMethod(string line)
        {
            string[] parameters = line.Split(',');
            int id = Convert.ToInt32(parameters[1]);
            string name = parameters[2];

            if (parameters[0] == "Teacher")
            {
                int experience = Convert.ToInt32(parameters[3]);
                return new Teacher(id, name, experience);
            }
            if (parameters[0] == "Student")
            {
                return new Student(id, name);
            }
            if (parameters[0] == "Course")
            {
                int teacherId = Convert.ToInt32(parameters[3]);
                return new Course(id, name, teacherId);
            }

            throw new Exception("Invalid entity type.");
        }
    }
}
