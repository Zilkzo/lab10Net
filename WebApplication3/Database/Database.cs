using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3
{
    public class Database
    {
        
        private Database() {}
        public static Database shared = new Database();

        public List<Student> students
        {
            get
            {
                List<Student> students = new List<Student>();
                students.Add(new Student("Aigerim", "25-09-1999", "CSSE-1702"));
                students.Add(new Student("Zhibek", "23-06-1999", "CSSE-1702"));
                students.Add(new Student("Sultan", "14-01-1999", "CSSE-1705"));
                students.Add(new Student("Darkhan", "23-12-2000", "CSSE-1705"));
                students.Add(new Student("Arsu", "12-02-1999", "CSSE-1703"));
                students.Add(new Student("Aidana", "20-11-1999", "CSSE-1709"));
                students.Add(new Student("Galymzhan", "18-04-1999", "CSSE-1709"));
                students.Add(new Student("Abylai", "23-12-1999", "CSSE-1905"));
                students.Add(new Student("Altynai", "14-06-2004", "CSSE-2001"));
                return students;
            }
        }
    }
}