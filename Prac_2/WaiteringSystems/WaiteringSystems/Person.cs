using System;
using System.Collections.Generic;
using System.Text;

namespace WaiteringSystems
{
 public class Person
    {
        //A class has to public because it has to commmunicate with other classes and thus it has to visible and accesable
        string Name;
        string ID;
        string Phone;

        public Person()
        {
            Name = " ";
            ID = " ";
            Phone = " ";

        }
        public Person (string name,string Id,string phone)
        {
            Name = name;
            ID = Id;
            Phone = phone;

        }
        // Declare a Name property of type string:
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        // Declare a ID property of type string:
        public string Id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        // Declare a Phone property of type string:
        public string phone
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        public override string ToString()
        {
            return Name +" "+ ID+" " +" "+ Phone;
        }
    }
    /*The key characteristics of an abstract are to hide the implementation details of methods in a class and only display
    important features of an object*/
}
