using OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    public class Teacher : SchoolStaff
    {
        public DateTime StartWorkTime { get; set; }
        public int StudentNumber { get; set; }
    }
}
