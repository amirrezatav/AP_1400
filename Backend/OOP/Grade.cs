using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    public class Gradev2
    {
        public static double Value { get;  /*private*/ set; }
        //public double Value {
        //    get { return Value; }
        //    set {
        //        if (value <= _max && value >= 0)
        //            Value = value;
        //        else throw new Exception($"value of Grade must less than {_max} and equal or greater than 0"); // throw error
        //    } 
        //}
        readonly double _max;
        public Gradev2(int max) => _max = max;
    }


    public class Grade
    {
        double _value;
        readonly double _max;
        public double Value
        {
            // get => _value;
            // or
            get
            { 
                return _value;
            }
            /* private */ set
            {
                if (value <= _max && value >= 0)
                    _value = value;
                else throw new Exception($"value of Grade must less than {_max} and equal or greater than 0"); // throw error
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="max">max of grade</param>
        public Grade(double max)
        {
            _max = max;
        }
        public void alaki()
        {
            _value = 5;
        }
    }
}
