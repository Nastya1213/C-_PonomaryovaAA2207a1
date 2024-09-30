using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Course : Entity
    {
        public int TeacherId { get; set; }
        public List<int> StudentIds { get; } = new List<int>();

        public Course(int id, string name, int teacherId) : base(id, name)
        {
            TeacherId = teacherId;
        }

        public bool AddStudent(int studentId)
        {
            if (!StudentIds.Contains(studentId))
            {
                StudentIds.Add(studentId);
                return true;
            }
            return false;
        }
    }
}
