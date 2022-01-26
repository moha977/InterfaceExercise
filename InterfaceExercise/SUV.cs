using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }
        public double CargoSize { get; set; } = 5.6;
        public string SuvName { get; set; } = "Breaker";
        public int Year { get; set; } = 2010;
        public string Make { get; set; } = "Chevy";
        public string Model { get; set; } = "GX5";
        public string color { get; set; } = "White";
        public string Insurance { get; set; } = "Gieco";
        public string InsuranceType { get; set; } = "Full Coverage";

        public void SuvDetails()
        {
            Console.WriteLine($"I have a {Make} {Model}, {Year}.\n" +
                $"I named it {SuvName}, it has a {CargoSize} truck size, and it's {color}.\n" +
                $"I got {InsuranceType} {Insurance} insurance on it, and i'm enjoying it. ");
        }
    }
}
