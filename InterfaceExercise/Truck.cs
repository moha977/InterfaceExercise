using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }
        public double TruckSize { get; set; } = 24;
        public string TruckName { get; set; } = "Mover";
        public int Year { get; set; } = 2022;
        public string Make { get; set; } = "Merceds";
        public string Model { get; set; } = "Gx20";
        public string color { get; set; } = "Silver";
        public string Insurance { get; set; } = "Auto";
        public string InsuranceType { get; set; } = "Full Coverage";

        public void TruckDetails()
        {
            Console.WriteLine($"I have a {Make} {Model}, {Year}.\n" +
                $"I named it {TruckName}, it has a {TruckSize} truck size, and it's {color}.\n" +
                $"I got {InsuranceType} {Insurance} insurance on it, and i'm using it. ");
        }
    }
}
