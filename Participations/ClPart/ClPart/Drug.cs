using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClPart
{
    internal class Drug
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Brand { get; set; }
        public int Code { get; set; }
        public string StreetName { get; set; }

        public Drug()
        {
            Name = String.Empty;
            Company = String.Empty;
            Brand = String.Empty;
            Code = 0;
            StreetName = String.Empty;
        }
        public override string ToString()
        {
            string s = $"Company: {Company}, StreetName: {StreetName}, Code: {Code.ToString("G0")}";
            return s;
        }
    }

}
