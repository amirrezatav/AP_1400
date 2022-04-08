using OOP.Entity;
using OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Repository
{
    public class StudentRepository
    {
        List<Student> StudentsContext;
        List<Grade> GradesContext;
        List<Teacher> TeachersContext;
        List<Course> CoursesContext;

        public StudentRepository()
        {
            StudentsContext = new List<Student>();
            GradesContext = new List<Grade>();
            TeachersContext = new List<Teacher>();
            CoursesContext = new List<Course>();
        }

        #region Student

        // CRUD in List
        // Create
        public Student CreateStudent(Student newstudent)
        {
            if(StudentsContext.Where(x => x.Id == newstudent.Id).Any())
            {
                throw new Exception($"Student with StudentId = {newstudent.Id} already is exist ");
            }
            else
            {
                StudentsContext.Add(newstudent);
                return newstudent;
            }
        }
        // Read
        public Student GetStudentById(int Id)
        {
            //foreach (Student student in StudentsContext)
            //{
            //    if (student.Id == Id)
            //        return student;
            //}
            //for(int i = 0; i < StudentsContext.Count; i++)
            //{
            //    if(StudentsContext[i].Id == Id)
            //        return StudentsContext[i];
            //}
            return StudentsContext.Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<Student> SearchByFirstName(string FirstName)
        {
            return StudentsContext.Where(x => x.FirstName.Contains(FirstName)).ToList();
        }
        // Update
        public Student UpdateStudent(Student newstudent)
        {
            if (StudentsContext.Exists(x => x.Id == newstudent.Id))
            {
                int studentindex = StudentsContext.FindIndex(x => x.Id == newstudent.Id);
                StudentsContext[studentindex] = newstudent;
                return newstudent;
            }
            else
            {
                throw new Exception("Student Not Exists!");
            }
        }
        // Delete
        public void DeleteStudent(int id)
        {
            var student = StudentsContext.SingleOrDefault(x => x.Id == id);
            StudentsContext.Remove(student);
        }

        #endregion

        #region Teacher
        public Teacher CreateTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }
        public Teacher GetTeacherById(int id)
        {
            throw new NotImplementedException();
        }
        public List<Teacher> SerachTeacher(string Fname , string Lname , Gender gender)
        {
            throw new NotImplementedException();
        }
        public Teacher UpdateTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }
        public void DeleteTeacher(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Grade
        public Grade AddStudentGrade(int studentid , Grade grade)
        {
            throw new NotImplementedException();
        }
        public List<Grade> GetCourseGrades(int Course)
        {
            throw new NotImplementedException();
        }
        public Grade UpdateStudentGrade(int studentid, Grade grade)
        {
            throw new NotImplementedException();
        }
        public Grade DeleteStudentGrade(int studentid, Grade grade)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Course
        // خودتان توابع درس را تعریف کنید.
        #endregion
    }
}
