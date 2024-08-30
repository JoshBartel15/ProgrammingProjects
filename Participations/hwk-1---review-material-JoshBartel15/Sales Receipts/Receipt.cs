using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Receipts
{
    internal class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        public DateTime SaleDate { get; set; }
        private double SalesTaxPercent;
        private double CogPrice;
        private double GearPrice;

        public Receipt()
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Now;
            SalesTaxPercent = 0.089;
            CogPrice = 79.99;
            GearPrice = 250.00;
        }

        public Receipt(int id, int cog, int gear)
        {
            CustomerID = id;
            CogQuantity = cog;
            GearQuantity = gear;
            SaleDate = DateTime.Now;
            SalesTaxPercent = 0.089;
            CogPrice = 79.99;
            GearPrice = 250.00;
        }
        public double CalculateTotal()
        {
            double netAmount = CalculateNetAmount();
            double taxAmount = CalculateTaxAmount();

            return netAmount + taxAmount;
        }
        public void PrintReceipt()
        {
            string receipt = $"\t{string.Empty.PadLeft(40, '#')}\n" +
                     $"\t{"".PadLeft(05, ' ') + "Customer:"} {CustomerID}\n" +
                     $"\t{string.Empty.PadLeft(40, '-')}\n" +
                     $"\t{"# of cogs:".PadRight(15, ' ')} {CogQuantity.ToString("N0")}\n" +
                     $"\t{"# of gears:".PadRight(15, ' ')} {GearQuantity.ToString("N0")}\n" +
                     $"\t{"Subtotal:".PadRight(15, ' ')} {CalculateNetAmount().ToString("C2")}\n" +
                     $"\t{"Sales Tax:".PadRight(15, ' ')} {CalculateTaxAmount().ToString("C2")}\n" +
                     $"\t{"Total:".PadRight(15, ' ')} {CalculateTotal().ToString("C2")}\n" +
                     $"\t{string.Empty.PadLeft(40, '#')}\n";

            Console.WriteLine(receipt);
        }
        private double CalculateTaxAmount()
        {
            return CalculateNetAmount() * SalesTaxPercent;
        }
        private double CalculateNetAmount()
        {
           double NetAmount, CogPricewithMarkup, GearPricewithMarkup;

            if (CogQuantity > 10 || GearQuantity > 10 || (CogQuantity + GearQuantity) > 16)
            {
                CogPricewithMarkup = CogPrice + CogPrice * .125;
                GearPricewithMarkup = GearPrice + GearPrice * .125;
            }
            else
            {
                CogPricewithMarkup = CogPrice + CogPrice * .15;
                GearPricewithMarkup = GearPrice + GearPrice * .15;
            }

            NetAmount = CogQuantity * CogPricewithMarkup + GearQuantity * GearPricewithMarkup;

            return NetAmount;
        }
    }
}


