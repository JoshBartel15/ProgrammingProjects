using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParticipation2
{
    public class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public double Price { get; set; }

        public Car()
        {
            Make = string.Empty;
            Model = string.Empty;
            Year = 0;
            Color = string.Empty;
            VIN = string.Empty;
            Price = 0;
        }

        public override string ToString()
        {
            return $"{Make}, {Year.ToString("G0")}, {Price.ToString("C2")}";
        }
    }
}
