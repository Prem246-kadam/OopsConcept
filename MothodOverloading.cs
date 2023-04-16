using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Polymorphism
{
    class Addition
    {
       public void Addnumbers(int first, int second)
        {
            Console.WriteLine(("Sum" +  first  + second));
        }
        // varying parameters
        public void AddNumbers(int first, int second, int third)
        {
            Console.WriteLine(("Sum" + first + second + third));
        }
        // changing datatype
        public void AddNumbers(int first, double second, int third)
        {
            Console.WriteLine(("Sum:"+ first + second + third));
        }
        
    }
}
