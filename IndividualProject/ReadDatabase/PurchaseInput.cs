using ReadDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDatabase
{
     public class PurchaseInput
    {
        public string name { get; set; }
        public string purchasedate { get; set; }

        public string saledate { get; set; }

        public PurchaseInput()
        {
            name = string.Empty;
            purchasedate = string.Empty;
            saledate = string.Empty;
        }

        public override string ToString()
        {
            return $"{purchasedate} {saledate}";
        }
    }
}
