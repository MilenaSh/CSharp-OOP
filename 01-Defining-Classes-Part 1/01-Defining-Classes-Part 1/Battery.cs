﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes_Part_1
{
    public class Battery
    {
        //fields

        private BatteryType BatteryType;


        // properties

        public string Model { get; set; }

        public int HoursIdle { get; set; }

        public int HoursTalk { get; set; }

        public Battery MyBatteryType { get; set; }

    }
}
