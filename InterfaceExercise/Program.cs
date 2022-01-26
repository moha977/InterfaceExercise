using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var Car = new Car
            {
                color = "Green",
                Year = 2017,
                Make = "Merceds",
                Model = "AMG",
                CarName = "Amoriss",
                TrunkSize = 2.4,
                
            
            };
            Car.CarDetails();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var Truck = new Truck
            {
                color = "Blue",
                Year = 2015,
                Make = "Ford",
                Model = "Ranger",
                TruckName = "Mover",
                TruckSize = 4

            };
             Truck.TruckDetails();
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine();

            var SUV = new SUV
            {
                color = "Yellow",
                Make = "GMC",
                Model = "Gx45",
                SuvName = "Helper",
                Year = 2013,
                CargoSize = 5.4

            };
            SUV.SuvDetails();
            


        }
    }
}
