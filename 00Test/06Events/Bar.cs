using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Events
{
    internal class Bar
    {
        public event EventHandler SpendRountEvent;
        public string Name { get; set; }
        public void SpendRound()
        {
            if (this.SpendRountEvent != null) // ob Methoden registiert sind
            {
                SpendRountEvent(this, EventArgs.Empty);
            }
        }
    }
}
