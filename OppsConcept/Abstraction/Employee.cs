using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Abstraction
{
     abstract class Employee
    {
        public string name;

        public abstract void GetSalary();

        public void GetSalDetails()
        {
            Console.WriteLine("Name od emp is :"+ name);
        }
    }
}
