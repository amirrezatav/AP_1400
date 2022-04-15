using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    public class Student : IComparable<Student> , IEquatable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompareTo(Student student)
        {
            if (student == null)
                return 1;
            else
                return this.Id.CompareTo(student.Id);
        }
        public bool Equals(Student other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> MyList;
            MyList = new List<Student>();
            //////////////////////////////////////// Add To List 
            MyList.Add(new Student { Id = 1, Name = "Ali" });
            MyList.Add(new Student { Id = 2, Name = "Amir" });
            MyList.Add(new Student { Id = 3, Name = "Hasan" });
            MyList.Add(new Student { Id = 1, Name = "Hamid" });
            MyList.Add(new Student { Id = 4, Name = "Babaei" });
            MyList.Add(new Student { Id = 3, Name = "Ali" });
            MyList.Add(new Student { Id = 5, Name = "Ali" });
            List<Student> MyList2 = new List<Student> {
                new Student {Id=1,Name="Ali" },
                new Student {Id=3,Name="Mohammad" } ,
                new Student {Id=7,Name="Jamshid" },
                new Student {Id=8,Name="Saheb" }
            };
            MyList.AddRange(MyList2);
            MyList.Insert(3, new Student { Id = 16, Name = "Amir Ali" });
            MyList.InsertRange(3, MyList2);
            // MyList = MyList.Append(2.5).ToList(); Not Important
            //////////////////////////////////////// Remove from List
            MyList.Remove(new Student { Id = 16, Name = "Amir Ali" }); // Remove First 
            MyList.RemoveAt(2);
            // Remove All Item
            MyList.Clear();
            //////////////////////////////////////// Read(Fetch) Form List
            var a = MyList[0];
            // is equal
            var aa = MyList.ElementAt(2);
            var aaa = MyList.ElementAtOrDefault(20);
            //////////////////////////////////////// Update
            MyList[0] = new Student { Id = 1, Name = "Ali" };
            while (MyList.Exists(x => x.Id == 2))
            {
                var indexes = MyList.FindIndex(item => item.Id == 2);
                MyList[indexes] = new Student { Id = 5, Name = "Ali" };
            }
            ////////////////////////////////////// Search 
            Student res = MyList.Find(item => item.Id == 2); // first element
            res = MyList.FindLast(item => item.Id == 3); // last element
            int studentindex = MyList.FindIndex(item => item.Id == 2); // index of first element
            studentindex = MyList.FindLastIndex(item => item.Id == 8); // index of last element
            studentindex = MyList.IndexOf(new Student { Id = 1, Name = "Ali" }); //  first element
            List<Student> reslist = MyList.FindAll(item => item.Id < 5); // All iteme
            bool IsContain = MyList.Contains(new Student { Id = 1, Name = "Ali" });
            IsContain = MyList.Exists(x => x.Name.StartsWith("A") || x.Name.StartsWith("a"));
            IsContain = MyList.Any(x => x.Name.StartsWith("A") || x.Name.StartsWith("a"));
            if (MyList.Any())
            {
                // list has something
            }
            else
            {// list empty }

            }
            // recommand
            IEnumerable<Student> resWhere = MyList.Where(x => x.Id < 5 && (x.Name.EndsWith("i") || x.Name.EndsWith("I")));

            MyList.Sort();

            // 1- IEnumerable
            // 2- Icollection : IEnumerable
            // 3- Ilist : Icollection
            // 4- List : Ilist
            // 5- HashSet : Icollection
            // 6- SortedList : Ilist

        }
    }
}
