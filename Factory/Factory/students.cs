using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Student : Entity
    {
        public List<int> CourseIds { get; } = new List<int>();

        public Student(int id, string name) : base(id, name)
        {
        }

        public bool AddCourse(int courseId)
        {
            if (!CourseIds.Contains(courseId))
            {
                CourseIds.Add(courseId);
                return true;
            }
            return false;
        }
    }
}
