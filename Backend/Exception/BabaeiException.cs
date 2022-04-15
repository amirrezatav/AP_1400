using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    public class BabaeiException : System.Exception
    {
        public override string Source { get; set; }
        public BabaeiException() : base()
        {

        }
        public BabaeiException(string Message) : base(Message)
        {
            Source = "Babaei Source";
        }
    }
}
