using OOP.Entity;
using OOP.IRepository;
using OOP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static Tuple<int,double,string,float, StudentRepository> Test()
        {
            // Do Something
            return Tuple.Create(1, 2.59, "Hello", 2.3f, new StudentRepository());
        }
        static void Main(string[] args)
        {
            IStudentRepository th = new StudentRepository();
            th.Search(
                FirstName:"Ali",
                BirthDate: DateTime.Now );

            var res = Test();
            Console.WriteLine(res.Item1);
            Console.WriteLine(res.Item2);
            Console.WriteLine(res.Item3);

        }
    }
}
