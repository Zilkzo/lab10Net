using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Group { get; set; }

        public Student(string Name, string Birthdate, string Group)
        {
            this.Name = Name;
            this.Birthdate = Birthdate;
            this.Group = Group;
        }
    }
}