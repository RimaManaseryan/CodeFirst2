using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Grade { get; set; }
        public string TeacherName { get; set; }
        public string Username { get; set; }
        public string University { get; set; }

        public Student() { }
        public Student(string name, string surname, string username,string universeity, int grade, string teacher)
        {
            Name = name;
            Surname = surname;
            Username = username;
            University = universeity;
            Grade = grade;
            TeacherName = teacher;
        }
    }
}
