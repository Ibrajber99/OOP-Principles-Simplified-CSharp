using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Medium
{
    public class Professor : Person
    {
        public Professor()
        {
            this.FirstName = "James";
            this.LastName = "Lucas";

            // ID is private and it cannot be accessed from derived class
            // to have it accessable you need to set the property as protected.
            // for nopw the ID is generated in the COnsturcotr of Person so we will have the value already set for us.
        }


        // we override the method from Person, and have a different return value.
        public override string GetFullName()
        {
            return  $"The Professor name is {this.FirstName} {this.LastName}";
        }
    }
}
