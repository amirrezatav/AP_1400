using OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string MobilePhone { get; set; }
        // ICollection<Course> -> Collection of Courses
        // List<Course> -> List of Courses
        public ICollection<Course> Courses { get; set; } 
    }
}
