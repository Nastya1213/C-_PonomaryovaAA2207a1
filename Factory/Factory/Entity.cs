using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{


    public abstract class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        internal Entity(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
