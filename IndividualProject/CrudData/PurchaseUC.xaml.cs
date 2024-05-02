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
    /// Interaction logic for PurchaseUC.xaml
    /// </summary>
    public partial class PurchaseUC : Window
    {
        DB_128040_bart0146Context db = new DB_128040_bart0146Context();
        public Purchase purchase;

        public PurchaseUC(Purchase p)
        {
            InitializeComponent();

            btnUpdate.Visibility = Visibility.Visible;
            btnGetCar.Visibility = Visibility.Visible;
            btnCreate.Visibility = Visibility.Hidden;

            foreach (var item in db.Owners)
            {
                cmbOwner.Items.Add(item);
            }
            foreach (var item in db.Cars)
            {
                cmbCar.Items.Add(item);
            }
        }
        public PurchaseUC()
        {
            InitializeComponent();

            btnUpdate.Visibility = Visibility.Hidden;
            btnGetCar.Visibility = Visibility.Hidden;
            btnCreate.Visibility = Visibility.Visible;

            foreach (var item in db.Owners)
            {
                cmbOwner.Items.Add(item);
            }
            foreach (var item in db.Cars)
            {
                cmbCar.Items.Add(item);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (purchase != null)
            {
                purchase.PurchaseDate = txtPurch.Text;
                purchase.SaleDate = txtSale.Text;
                purchase.OwnerId = ((Owner)cmbOwner.SelectedItem).OwnerId;
                purchase.CarId = ((Car)cmbCar.SelectedItem).CarId;
                MessageBox.Show("Purchase updated");
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            using (DB_128040_bart0146Context db = new DB_128040_bart0146Context())
            {
                Purchase purchase = new Purchase();

                Owner purch = (Owner)cmbOwner.SelectedItem;
                Car car = (Car)cmbCar.SelectedItem;
                    purchase.PurchaseDate = txtPurch.Text;
                    purchase.SaleDate = txtSale.Text;
                if (purch == null)
                {
                    MessageBox.Show("Please select owner");
                    return;
                }
                if (car == null)
                {
                      MessageBox.Show("Please select car");
                    return;
                }
                    purchase.OwnerId = ((Owner)cmbOwner.SelectedItem).OwnerId;
                    purchase.CarId = ((Car)cmbCar.SelectedItem).CarId;
                db.Purchases.Add(purchase);
                db.SaveChanges();
                MessageBox.Show("Purchase created");
            }
        }

        private void btnGetCar_Click(object sender, RoutedEventArgs e)
        {
            if (purchase != null)
            {
                cmbCar.SelectedItem = purchase.Car;
                cmbOwner.SelectedItem = purchase.Owner;
                txtPurch.Text = purchase.PurchaseDate;
                txtSale.Text = purchase.SaleDate;
            }
        }
    }
}
