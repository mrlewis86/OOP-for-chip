using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle Bike = new Motorcycle()
            {
                ColorHandleBars = "silver",
                Make = "Harley",
                Model = "F10",
                Price = 12000,
                Year = 2010
            };


            car Toyota = new car()
            {
                Model = "Camry",
                Make = "Toyota",
                NumberofDoors = 4,
                NumberofTires = 2,
                Year = 2014,
                Price = 15999
            };


            Toyota.Display();
            //this is an example of polymorphism. the same method name, diff results
            


            Console.ReadLine();

        }




    }
}
