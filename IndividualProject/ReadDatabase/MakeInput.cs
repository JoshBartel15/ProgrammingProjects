using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDatabase
{
    public class MakeInput
    {
        public string make { get; set; }

        public string CEO { get; set; }

        public int Founded { get; set; }

        public string Website { get; set; }

        public override string ToString()
        {
            return $" {make} {CEO} {Founded} {Website}";
        }
    }
}
