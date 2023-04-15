using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Abstraction
{
   class PartTimeEmployee : Employee
    {
        public override void GetSalary()
        {
            Console.WriteLine("50000");
        }
    }
}
