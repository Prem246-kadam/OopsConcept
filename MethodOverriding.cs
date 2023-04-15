using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Polymorphism
{
    class Animal
    {
        public string name;
        public virtual void Run()
        {
            Console.WriteLine("running slow");

        }
        public void AnimalDetails()
        {
            Console.WriteLine("Name of animal:" + name);
                }

    }
    class lion:Animal
    {
        public override void Run()
        {
            Console.WriteLine("Running Faster");
                
        }
    }
}
