﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Year { get; set; }   
        public string Make { get; set; }
        public string Model { get; set; }
        public string color { get; set; }
    }
}
