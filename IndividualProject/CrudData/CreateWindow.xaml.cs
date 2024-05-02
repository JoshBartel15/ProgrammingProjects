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
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        DB_128040_bart0146Context db = new DB_128040_bart0146Context();
        public Car car = new Car();
        public CreateWindow()
        {
            InitializeComponent();

            fv();
        }

        private void fv()
        {
                foreach (Car c in db.Cars)
                {
                    if (!cmbColor.Items.Contains(c.Color))
                    {
                        cmbColor.Items.Add(c.Color);
                    }
                }
                foreach (Car c in db.Cars)
                {
                    if (!cmbType.Items.Contains(c.Type))
                    {
                        cmbType.Items.Add(c.Type);
                    }
                }
                foreach (Make m in db.Makes)
                {
                    if (!cmbMake.Items.Contains(m.Make1))
                    {
                        cmbMake.Items.Add(m.Make1);
                    }
                }
        }

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            //validate the data
            if (txtVIN.Text == "")
            {
                MessageBox.Show("Please enter a VIN");
                return;
            }
            if (txtModel.Text == "")
            {
                MessageBox.Show("Please enter a Model");
                return;
            }
            if (txtYear.Text == "")
            {
                MessageBox.Show("Please enter a Year");
                return;
            }
            if (cmbMake.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a Make");
                return;
            }
            if (cmbColor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Color");
                return;
            }
            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Type");
                return;
            }

                car.Vin = txtVIN.Text;
                car.Model = txtModel.Text;
            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year");
                return;
            }
            car.Year = year;
            car.Make = db.Makes.Where(m => m.Make1 == cmbMake.Text).FirstOrDefault();
                car.Color = cmbColor.Text;
                car.Type = cmbType.Text;
            MessageBox.Show("Car Added");

            lblNewCar.Content = car.ToString();
            db.Cars.Add(car);
            db.SaveChanges();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtVIN.Clear();
            txtModel.Clear();
            txtYear.Clear();
            cmbMake.SelectedIndex= -1;
            cmbColor.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
