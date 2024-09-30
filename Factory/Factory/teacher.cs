using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Teacher : Entity
    {
        public int Experience { get; set; }
        public List<int> CourseIds { get; } = new List<int>();

        public Teacher(int id, string name, int experience) : base(id, name)
        {
            Experience = experience;
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