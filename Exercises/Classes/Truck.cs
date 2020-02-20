﻿using Exercises.SuperClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Classes
{
    class Truck : Vehicle, IAutomobile
    {


        public double Weight
        { get; }

        public Truck(double speed, double weight) :base(speed)
        {
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public override string Describe()
        {
            return $"This Track is {Weight} and is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }
    }
}
