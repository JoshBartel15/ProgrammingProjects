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
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        DB_128040_bart0146Context db = new DB_128040_bart0146Context();
        public Car car;

        public EditWindow()
        {
            InitializeComponent();

            fillcmb();
            //assignv();
        }

        private void fillcmb()
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
        private void assignv()
        {
            if (car != null)
            {
                cmbColor.Text = car.Color;
                cmbType.Text = car.Type;
                cmbMake.Text = car.Make.Make1;
                txtYear.Text = car.Year.ToString();
                txtModel.Text = car.Model;
                txtVIN.Text = car.Vin;
            }
            lblNewCar.Content = car.ToString();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //make sure car is not null then use the values from the edit window to update the car
            if (car != null)
            {
                car.Color = cmbColor.Text;
                car.Type = cmbType.Text;
                car.Make = db.Makes.Where(m => m.Make1 == cmbMake.Text).FirstOrDefault();
                //check if the year is a valid number
                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MessageBox.Show("Please enter a valid year");
                    return;
                }
                car.Year = year;
                car.Model = txtModel.Text;
                car.Vin = txtVIN.Text;
            }
            lblNewCar.Content = car.ToString();
            MessageBox.Show("Car Updated");
        }

        private void btnTrans_Click(object sender, RoutedEventArgs e)
        {
            assignv();
        }
    }
}
