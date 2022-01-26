using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public double TrunkSize { get; set; } = 3.1;
        public string CarName { get; set; } = "Lover";
        public int Year { get; set; } = 2019;
        public string Make { get; set; } = "BMW";
        public string Model { get; set; } = "X6";
        public string color { get; set; } = "Black";
        public string Insurance { get; set; } = "State Farm";
        public string InsuranceType { get; set; } = "Libilty";

        public void CarDetails()
        {
            Console.WriteLine($"I have a {Make} {Model}, {Year}.\n" +
                $"I named it {CarName}, it has a {TrunkSize} truck size, and it's {color}.\n" +
                $"I got {InsuranceType} {Insurance} insurance on it, and i'm lovin it. ");
        }
    }
}
