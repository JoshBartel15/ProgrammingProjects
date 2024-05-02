using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromAFile
{
    internal class CarOwner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public CarOwner() 
        {
            FirstName = "";
            LastName = "";
            Make = "";
            Model = "";
            Year = 0;
            Color = "";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} owns a {Color} {Year} {Make} {Model}";
        }
    }
}
