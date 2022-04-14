using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.IRepository
{
    public interface IStudentRepository
    {
         Student CreateStudent(Student newstudent);
         Student GetStudentById(int Id);
         List<Student> Search(string FirstName, string LastName = null, DateTime? BirthDate = null);
         Student UpdateStudent(Student newstudent);
         void DeleteStudent(int id);
    }
}
