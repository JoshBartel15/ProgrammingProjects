using ReadDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDatabase
{
    public class CarInput
    {
        public string VIN { get; set; }

        public int Year { get; set; }

        public MakeInput Make { get; set; }

        public string Model { get; set; }

        public List<PurchaseInput> Owners { get; set; }

        public string Color { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            return $" {VIN} {Year} {Model} {Color} {Type}";
        }
    }
}
