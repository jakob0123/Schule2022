using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Gruppe1_2_
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstname, string lastname)
        {
            this.firstName = firstname;
            this.lastName = lastname;
        }

        public event EventHandler<EventArgs> LastNameChanged;

        public string LastName
        {
            get { return lastName; }
            set
            {

                lastName = value;
                if (this.LastNameChanged != null)
                {
                    this.LastNameChanged(this, EventArgs.Empty);
                }

            }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }
}
