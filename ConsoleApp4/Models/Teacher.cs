using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string Subject { get; set; }
        public decimal Salary { get; set; }

        public Teacher() { }
        public Teacher(string name, string subject, decimal salary)
        {
            TeacherName = name;
            Subject = subject;
            Salary = salary;
        }
    }
}
