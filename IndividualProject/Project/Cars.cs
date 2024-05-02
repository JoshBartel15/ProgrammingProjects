using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Cars
    {
        public string VIN { get; set; }
        public int Year { get; set; }
        public Make Make { get; set; }
        public string Model { get; set; }
        public List<Owner> Owners { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public Cars()
        {
            VIN = "";
            Year = 0;
            Make = new Make();
            Model = "";
            Owners = new List<Owner>();
            Color = "";
            Type = "";
        }

        public Cars(string line) : this()
        {

            string[] p = line.Split(',');
            VIN = p[0];
            Year = int.Parse(p[1]);
            Make = new Make(p[2]);
            Model = p[3];
            string[] op = p[4].Split('|');
            foreach (string item in op)
            {
                Owner o = new Owner(item);
                Owners.Add(o);
            }
            Color = p[5];
            Type = p[6];
            switch (Type.ToLower())
            {
                case "sean":
                case "sadan":
                case "sedan":
                    Type = "Sedan";
                    break;
                case "coup":
                case "coupe":
                    Type = "Coupe";
                    break;
                case "truck":
                    Type = "Truck";
                    break;
                case "van":
                    Type = "Van";
                    break;
                case "suv":
                    Type = "SUV";
                    break;
                case "convertibal":
                case "convertible":
                    Type = "Convertible";
                    break;
                case "hatchback":
                    Type = "Hatchback";
                    break;
            }
            switch (Color.ToLower())
            {
                case "red":
                case "read":
                    Color = "Red";
                    break;
                case "blue":
                case "bleu":
                    Color = "Blue";
                    break;
                case "green":
                    Color = "Green";
                    break;
                case "yellow":
                    Color = "Yellow";
                    break;
                case "orange":
                    Color = "Orange";
                    break;
                case "purple":
                    Color = "Purple";
                    break;
                case "black":
                case "blakc":
                    Color = "Black";
                    break;
                case "white":
                    Color = "White";
                    break;
                case "silver":
                case "sliver":
                case "silve":
                    Color = "Silver";
                    break;
                case "gray":
                case "grey":
                    Color = "Gray";
                    break;
                case "brown":
                    Color = "Brown";
                    break;
                case "maroon":
                    Color = "Maroon";
                    break;
                case "pink":
                    Color = "Pink";
                    break;
            }
        }

        public override string ToString()
        {

            
            string Owne = "";
            foreach (Owner item in Owners)
            {
                if (item == this.Owners.Last())
                {
                    Owne+= item.ToStringCSV2();
                }
                else
                {
                    Owne += item.ToStringCSV2() + "|";
                }
            }

            string make = Make.ToStringcars();

            return $"{VIN},{Year},{make},{Model},{Owne},{Color},{Type}";
        }
    }

    public class Owner
    {
        public string name { get; set; }
        public string? saledate { get; set; } //DateTime?
        public string purchasedate { get; set; } // DateTime
        public Owner()
        {
            name = "";
            saledate = null;
            purchasedate = ""; //DateTime.Now;
        }
        public Owner(string line)
        {
            string[] op = line.Split(';');
            name = op[0];
            purchasedate = op[1]; //Convert.ToDateTime(op[1]);

            if (op.Length == 3)
            {
                saledate = op[2]; //Convert.ToDateTime(op[2]);
            }
            else
            {
                saledate = null;
            }
        }
        public override string ToString() // for owners listbox
        {
            return $"{name}";
        }

        public string ToStringCSV2() // for cars
        {
            if (saledate == null)
            {
                return $"{name};{purchasedate}";
            }
            else
            {
                return $"{name};{purchasedate};{saledate}";
            }
        }
    }

    public class Make
    {
        public string make { get; set; }
        public string CEO { get; set; }
        public int Founded { get; set; }
        public string Website { get; set; }

        public Make()
        {
            make = "";
            CEO = "";
            Founded = 0;
            Website = "";
        }

        public Make(string line)
        {
            string[] p = line.Split('|');
            make = p[0];
            CEO = p[1];
            Founded = int.Parse(p[2]);
            Website = p[3];
        }

        public override string ToString() // for makes listbox
        {
            return $"{make},{CEO},{Founded},{Website}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Make)
            {
                Make m = (Make)obj;
                return m.make == this.make;
            }
            return false;
        }
        public string ToStringcars() // for cars
        {
            return $"{make}|{CEO}|{Founded}|{Website}";
        }
    }
}