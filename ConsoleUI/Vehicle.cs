using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle

    /*
     * Create an abstract class called Vehicle// Done
     * The vehicle class shall have three string properties Year, Make, and Model// Done
     * Set the defaults to something generic in the Vehicle class//Done
     * Vehicle shall have an abstract method called DriveAbstract with no implementation// Done
     * Vehicle shall have a virtual method called DriveVirtual with a base implementation.// Done
     */

    /* 
         * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
         * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
         * Provide the implementations for the abstract methods
         * Only in the Motorcycle class will you override the virtual drive method
        */

    {
        public string Year { get; set; } = "1";
        public string Make { get; set; } = "Default Toyota";
        public string Model { get; set; } = "Default Sienna";

        //abstract method

        public abstract void DriveAbstract();// stubbed out method
        public virtual void DriveVirtual()// with implementation or scope
        {
            Console.WriteLine($"This {GetType().Name} is driving virtually");
        
        }
         }
    
    
}
