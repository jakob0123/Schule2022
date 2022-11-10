using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Call_by_value_reference
{
    internal class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
}
