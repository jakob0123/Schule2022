using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompareable
{
    internal class Student:IComparable<Student>//ICompareable notwendig wenn ich sortieren möchte

    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }

        public int CompareTo(Student? other)
        {
            //bool lower = this.Birthday < other.Birthday;
            //if (lower)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 1;
            //}
            return this.Birthday.CompareTo(other.Birthday);   //nachdem auch DateTime Icompareable implementiert können wir dies einfach aufrufen.


        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " - " + Birthday.ToShortDateString;
        }
    }
}
