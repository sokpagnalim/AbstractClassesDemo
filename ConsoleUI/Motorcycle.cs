﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    { 
    
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in drive!!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is {GetType().BaseType.Name}is virtually drived.");
        }
    }
}

