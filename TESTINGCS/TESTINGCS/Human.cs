using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTINGCS
{
    class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Years { get; set; }

        public Human(string name, string lastName, int years)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Years = years;
        }

        public void Info()
        {
            Console.WriteLine(Name + " " + LastName + " have " + Years + " years old");
        }
    }
}
