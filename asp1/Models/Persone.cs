namespace asp1.Models
{
    public class Persone
    {
        public string Name { get; set;}
        public string Branch { get; set;}
        public string Id { get; set; }
        public string Age { get; set; } 
        public Persone() { }
        public Persone(string name, string branch, string id, string age) {
            Name = name;
            Branch = branch;  
            Id = id;
            Age = age;

        }


    }
}
