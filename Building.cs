using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building //This is a class named Building.
    {

        private string _designer; //This is a field.

        private DateTime _dateConstructed;

        private string _address;
        private string _owner;

        public int Stories { get; set; } //This is a property. Should be caps.

        public int Width { get; set; } //Get allows property to be read. Set allows it to be written or changed.

        public int Depth { get; set; }

        public int Volume
        {
            get { return (Width * Depth * (3 * Stories)); } //get is getting properties and doing logic.
        }

        public string Address {
            get {
            return _address;
            }
        }

        public string Designer {
            get
            {
                return _designer;
            }
        }

        public DateTime DateConstructed {
            get
            {
                return _dateConstructed;
            }
        }

        public string Owner {
            get
            {
                return _owner;
            }
        }


       public Building(string address) //This is a constructor. When you create a new instance of building must pass in a string and this sets the address field.
        {
            _address = address; //_address is the private field and it is set equal to the argument that was passed in the constructor.
            _designer = "Matthew Abebe"; //each time instance of building created _designer name is added with address.
        }

        public void Construct() { //Void not returning anything
            _dateConstructed = DateTime.Now; //Whenever Construct() is run on a building the time is added to it.
            
        }

        public void Purchase(string purchaser) {
            _owner = purchaser;
        }
}}


