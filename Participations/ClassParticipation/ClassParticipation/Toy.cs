using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassParticipation
{
    internal class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Notes;

        public Toy() 
        {
            Manufacturer = " ";
            Name = " ";
            Price = 0;
            Notes = " ";
        }
        public string GetAisle()
        {
            Random rand = new Random();
            double randomnumber = rand.Next(1, 24 + 1);
            return Manufacturer.ToUpper()[0].ToString() + randomnumber.ToString();
        }

        public string GetNotes()
        {
            return Notes;
        }

        public string TakeNotes(string n)
        {
            n = Notes;
            return n;
        }
    }
}
