using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Events
{
    internal class Persons
    {
        public string Name { get; set; }
        public void enter(Bar b)
        {
            b.SpendRountEvent += RecieveDrink;
        }
        public void leave(Bar b)
        {
            b.SpendRountEvent += RecieveDrink;
        }
        public void enter(ExtentedBar b)
        {
            b.SpendRoundEvent += RecieveDrinkExtended;
        }

        private void RecieveDrinkExtended(object? sender, DrinkEventArgs e)
        {
            if (e.Drink == DrinkType.Alcoholic)
            {
                Console.WriteLine(this.Name + " doesn't like alcoholic drinks");

            }
            else if (e.Drink  == DrinkType.NonAlcoholic)
            {
                Console.WriteLine(this.Name + " is happy about the drink");
            }
        }

        private void RecieveDrink(object? sender, EventArgs e)
        {
            Console.WriteLine(this.Name + " ist happy about the drink");
        }
    }
}
