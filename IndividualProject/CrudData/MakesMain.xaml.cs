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
using System.Windows.Shapes;

namespace CrudData
{
    /// <summary>
    /// Interaction logic for MakesMain.xaml
    /// </summary>
    public partial class MakesMain : Window
    {
        DB_128040_bart0146Context db = new DB_128040_bart0146Context();
        public MakesMain()
        {
            InitializeComponent();

            using (DB_128040_bart0146Context db1 = new DB_128040_bart0146Context())
            {
                List<Make> makes = db1.Makes.ToList();
                foreach (Make make in makes)
                {
                    lstMakes.Items.Add(make);
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //delete the selected make
            using (DB_128040_bart0146Context db = new DB_128040_bart0146Context())
            {
                Make selectedMake = (Make)lstMakes.SelectedItem;
                if (selectedMake == null)
                {
                    MessageBox.Show("Please select a car to delete");
                    return;
                }
                db.Makes.Remove(selectedMake);
                var cars = db.Cars.Where(c => c.MakeId == selectedMake.MakeId);
                foreach (var car in cars)
                {
                    db.Cars.Remove(car);
                }
                //delete the cars from the purchase table as well
                var purchases = db.Purchases.Where(p => p.Car.MakeId == selectedMake.MakeId);
                foreach (var purchase in purchases)
                {
                    db.Purchases.Remove(purchase);
                }
                db.SaveChanges();
                lstMakes.Items.Remove(selectedMake);
                MessageBox.Show("Make deleted");
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            MakeUCWindow makeUCWindow = new MakeUCWindow();
            makeUCWindow.ShowDialog();
            lstMakes.Items.Clear();
            foreach (var item in db.Makes)
            {
                lstMakes.Items.Add(item);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            MakeUCWindow makeUCWindow = new MakeUCWindow((Make)lstMakes.SelectedItem);
            makeUCWindow.make = (Make)lstMakes.SelectedItem;
            if (makeUCWindow.make == null)
            {
                MessageBox.Show("Please select a make");
                return;
            }
            makeUCWindow.ShowDialog();

            using (DB_128040_bart0146Context db1 = new DB_128040_bart0146Context())
            {

                //update the car in the database
                Make make = db1.Makes.Where(m => m.MakeId == makeUCWindow.make.MakeId).FirstOrDefault();
                make.Make1 = makeUCWindow.make.Make1;
                make.Ceo = makeUCWindow.make.Ceo;
                make.Website = makeUCWindow.make.Website;
                make.FoundedYear = makeUCWindow.make.FoundedYear;
                db1.SaveChanges();
                lstMakes.Items.Clear();
                foreach (var item in db.Makes)
                {
                    lstMakes.Items.Add(item);
                }
            }
        }
    }
}
