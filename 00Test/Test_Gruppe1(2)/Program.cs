using System;
using Test_Gruppe1_2_;

namespace Test_Gruppe1_2_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person anna = new Person("Anna", "Nass");
            Person ben = new Person("Ben", "Utzer");
            Person theo = new Person("Theo", "Logie");

            ben.LastNameChanged += LastNameChanged;
            anna.LastNameChanged += LastNameChanged;

            ben.LastName = "Zien";
            theo.LastName = "Retisch";

            Console.ReadLine();

             void LastNameChanged(object? sender, EventArgs e)
            {
                Person p = (Person)sender;
                Console.WriteLine("Der Nachname von " + p.FirstName + " " + p.LastName + " hat sich geändert.");
            }
            Console.ReadLine();

        }

    }
}