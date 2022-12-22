using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    internal class Coffee : IHotDrink
    {
        public Coffee(string type)
        {
            Type = type;
            Degree = 90;
        }

        public string Type { get; set; }
        public int Degree { get; set; }

        public void cool()
        {
            this.Degree -= 2;
        }
    }
}
