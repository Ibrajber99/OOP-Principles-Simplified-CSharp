using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Principles_Medium
{
    public abstract class Person
    {

        public Person() => this.ID = Guid.NewGuid().ToString();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsMarried { get; set; }


        // setting this variable as proteced so it can be accessed by derived classes I.E Professor class
        private String ID { get; set; }


        public string PublicID
        {
            get
            {
                return MaskID();
            }
        }


        // method to mask the Ineternal value of the ID
        // make method protected virtual, 
        private string MaskID()
        {
            var tempId = this.ID;

            var lastIndexOfDash = tempId.LastIndexOf('-');
            lastIndexOfDash++;

            var substractedValue = tempId.Length - lastIndexOfDash;

            var val = tempId.Remove(lastIndexOfDash, substractedValue);


            for(int i =0; i < substractedValue; i++)
            {
                val += '*';
            }

            return val;
        }

        // make it virtual so it can be overidden in derived classes.
        public virtual string GetFullName()
        {
            return $"The person name is {this.FirstName} {this.LastName}";
        }
    }
}
