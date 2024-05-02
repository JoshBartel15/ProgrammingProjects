using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using ReadDatabase.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReadDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB_128040_bart0146Context db = new DB_128040_bart0146Context();
        private bool ShouldLoadCar = false;
        private bool ShouldLoadOwner = false;
        private bool ShouldLoadMake = false;
        private bool ShouldLoadPurchase = false;
        public MainWindow()
        {
            InitializeComponent();
            ShouldLoadCar = true;
            ShouldLoadOwner = true;
            ShouldLoadMake = true;
            ShouldLoadPurchase = true;
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            MakeDBPop(ShouldLoadMake);
            OwnerDBPop(ShouldLoadOwner);
           CarDBPop(ShouldLoadCar);
           MessageBox.Show("Data Uploaded");
           PopListBox();
        }

        private void PopListBox()
        {
            foreach (var item in db.Owners)
            {
                lstOwner.Items.Add(item);
            }
            foreach (var item in db.Cars)
            {
                lstCar.Items.Add(item);
            }
            foreach (var item in db.Makes)
            {
                lstMake.Items.Add(item);
            }
            foreach (var item in db.Purchases)
            {
                lstPurchase.Items.Add(item);
            }
        }
        private void MakeDBPop(bool load)
        {
            if (load == false) return;
            using (DB_128040_bart0146Context db2 = new DB_128040_bart0146Context())
            {
                List<MakeInput> makes = JsonConvert.DeserializeObject<List<MakeInput>>(File.ReadAllText("Make.json"));

                foreach (var item in makes)
                {
                    db2.Makes.Add(new Make(item));
                }

                db2.SaveChanges();
            }
        }
        private void CarDBPop(bool load)
        {
            if (load == false) return;
            using (DB_128040_bart0146Context db1 = new DB_128040_bart0146Context())
            {
                List<CarInput> cars = JsonConvert.DeserializeObject<List<CarInput>>(File.ReadAllText("UsedCars.json"));
                foreach (var item in cars)
                {
                    Car car = new Car(item);
                    foreach (Make make in db1.Makes.ToList())
                    {
                        if (make.Make1 == item.Make.make)
                        {
                            car.MakeId   = make.MakeId;

                        }
                    }
                    db1.Cars.Add(car);
                }
                db1.SaveChanges();
                foreach (var ca in cars)
                {
                    foreach (var own in ca.Owners)
                    {
                        db1.Purchases.Add(new Purchase
                        {
                            CarId = db1.Cars.Where(c => c.Vin == ca.VIN).FirstOrDefault().CarId,
                            OwnerId = db1.Owners.Where(o => o.Name == own.name).FirstOrDefault().OwnerId,
                            SaleDate = own.saledate,
                            PurchaseDate = own.purchasedate
                        });
                    }
                }
                db1.SaveChanges();
            }
        }
        private void OwnerDBPop(bool load)
        {
            if (load == false) return;
            List<string> owners = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("Owner.json"));

            foreach (var item in owners)
            {
                db.Owners.Add(new Owner { Name = item});
            }
            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            List<Owner> owners = db.Owners.ToList();
            List<Car> cars = db.Cars.ToList();
            List<Make> makes = db.Makes.ToList();
            List<Purchase> purchases = db.Purchases.ToList();

            foreach (var item in owners)
            {
                db.Purchases.RemoveRange(db.Purchases.Where(p => p.OwnerId == item.OwnerId));
                db.Owners.Remove(item);
            }
            db.SaveChanges();
            foreach (var item in cars)
            {
                db.Purchases.RemoveRange(db.Purchases.Where(p => p.CarId == item.CarId));
                db.Cars.Remove(item);

            }
            db.SaveChanges();
            foreach (var item in makes)
            {
                db.Cars.RemoveRange(db.Cars.Where(c => c.MakeId == item.MakeId));
                db.Makes.Remove(item);
            }
            db.SaveChanges();
            foreach (var item in purchases)
            {
                db.Purchases.RemoveRange(db.Purchases.Where(p => p.CarId == item.CarId));
            }
            MessageBox.Show("All Data Deleted");

            lstCar.Items.Clear();
            lstMake.Items.Clear();
            lstOwner.Items.Clear();
            lstPurchase.Items.Clear();
            PopListBox();
        }
    }
}


