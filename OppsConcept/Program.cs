using OppsConcept.Abstraction;
using OppsConcept.Encapsulation;
using OppsConcept.Polymorphism;

namespace OppsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please one program from given options");
            Console.WriteLine("1.Inheritance 2.Methodoverloading 3.MethodOverriding 4.Abstraction");
            int option =Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Car car = new Car();
                    car.modelNumber = 2022;
                    car.brand = "BMW";
                    car.Start();
                    break;
                case 2:
                    Addition addition = new Addition();
                    addition.AddNumbers(10,30,40);
                    break;

                    case 3:
                    Animal animal = new Animal();
                    animal.name = "cow";
                    animal.AnimalDetails();
                    animal.Run();

                    lion lion = new lion();
                    lion.name = "Lion";
                    lion.AnimalDetails();
                    lion.Run();
                    break;

                case 4:
                  //  Employee  employee = new Employee();
                  PartTimeEmployee employee = new PartTimeEmployee();
                    employee.name = "Prem";
                    employee.GetSalDetails();
                    employee.GetSalary();
                   
                    break;

                case 5:
                   Student student = new Student();
                    Console.WriteLine("Please enter student name");
                    student.Name = Console.ReadLine();
                    Console.WriteLine(student.Name);
                    break;


            }
        }
    }
}