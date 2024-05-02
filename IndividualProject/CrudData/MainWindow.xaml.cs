using CrudData.Models;
using System;
using System.Collections.Generic;
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

namespace CrudData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        //DB_128040_bart0146Context db = new DB_128040_bart0146Context();
        public MainWindow()
        {
            InitializeComponent();

            using (DB_128040_bart0146Context db4 = new DB_128040_bart0146Context())
            {
                List<Car> ccars = db4.Cars.ToList();
                foreach (Car car in ccars)
                {
                    car.Make = db4.Makes.Where(m => m.MakeId == car.MakeId).FirstOrDefault();
                    lstCars.Items.Add(car);
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            editWindow.car = (Car)lstCars.SelectedItem;
            // make sure car is not null
            if (editWindow.car == null)
            {
                MessageBox.Show("Please select a car to edit");
                return;
            }
            editWindow.ShowDialog();
            using (DB_128040_bart0146Context db1 = new DB_128040_bart0146Context())
            {
                Car car = db1.Cars.Where(c => c.CarId == editWindow.car.CarId).FirstOrDefault();
                car.Color = editWindow.car.Color;
                car.MakeId = editWindow.car.MakeId;
                car.Model = editWindow.car.Model;
                car.Year = editWindow.car.Year;
                car.Type = editWindow.car.Type;
                car.Vin = editWindow.car.Vin;
                db1.SaveChanges();
                lstCars.Items.Refresh();
            }
        }

        private void btnDLT_Click(object sender, RoutedEventArgs e)
        {
            using (DB_128040_bart0146Context db2 = new DB_128040_bart0146Context())
            {
                Car car = (Car)lstCars.SelectedItem;
                if (car == null)
                {
                    MessageBox.Show("Please select a car to delete");
                    return;
                }
                List<Purchase> purchases = db2.Purchases.ToList();
                foreach (Purchase purchase in purchases)
                {
                    if (purchase.CarId == car.CarId)
                    {
                        db2.Purchases.Remove(purchase);
                    }
                }
                List<Owner> owners = db2.Owners.ToList();
                foreach (Owner owner in owners)
                {
                    if (owner.OwnerId == car.CarId)
                    {
                        db2.Owners.Remove(owner);
                    }
                }
                db2.Cars.Remove(car);
                db2.SaveChanges();
                lstCars.Items.Remove(car);
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow createWindow = new CreateWindow();
            createWindow.ShowDialog();
            lstCars.Items.Add(createWindow.car);
        }

        private void btnOwners_Click(object sender, RoutedEventArgs e)
        {
            OwnersMain ownersMain = new OwnersMain();
            ownersMain.ShowDialog();
        }

        private void btnMakes_Click(object sender, RoutedEventArgs e)
        {
            MakesMain makesMain = new MakesMain();
            makesMain.ShowDialog();
        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {
            PurchaseMain purchaseMain = new PurchaseMain();
            purchaseMain.ShowDialog();
        }
    }
}
