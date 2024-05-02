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
    /// Interaction logic for PurchaseMain.xaml
    /// </summary>
    public partial class PurchaseMain : Window
    {
        public PurchaseMain()
        {
            InitializeComponent();

            using( DB_128040_bart0146Context db1 = new DB_128040_bart0146Context())
            {
                //populate the list box with purchases
                List<Purchase> purchases = db1.Purchases.ToList();
                foreach (Purchase purchase in purchases)
                {
                    purchase.Car = db1.Cars.Where(c => c.CarId == purchase.CarId).FirstOrDefault();
                    purchase.Owner = db1.Owners.Where(o => o.OwnerId == purchase.OwnerId).FirstOrDefault();
                    lstPurchase.Items.Add(purchase);
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //delete the selected purchase
            using (DB_128040_bart0146Context db = new DB_128040_bart0146Context())
            {
                Purchase selectedPurchase = (Purchase)lstPurchase.SelectedItem;
                if (selectedPurchase == null)
                {
                    MessageBox.Show("Please select a purchase to delete");
                    return;
                }
                db.Purchases.Remove(selectedPurchase);
                db.SaveChanges();
                lstPurchase.Items.Remove(selectedPurchase);
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            PurchaseUC purchaseUC = new PurchaseUC();
            purchaseUC.ShowDialog();
            lstPurchase.Items.Refresh();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            PurchaseUC purchaseUC = new PurchaseUC((Purchase)lstPurchase.SelectedItem);
            purchaseUC.purchase = (Purchase)lstPurchase.SelectedItem;
            if (purchaseUC.purchase == null)
            {
                MessageBox.Show("Please select a purchase to edit");
                return;
            }
            purchaseUC.ShowDialog();

            using(DB_128040_bart0146Context db1 = new DB_128040_bart0146Context())
            {
                Purchase purchase = db1.Purchases.Where(p => p.PurchaseId == purchaseUC.purchase.PurchaseId).FirstOrDefault();
                purchase.CarId = purchaseUC.purchase.CarId;
                purchase.OwnerId = purchaseUC.purchase.OwnerId;
                purchase.PurchaseDate = purchaseUC.purchase.PurchaseDate;
                purchase.SaleDate = purchaseUC.purchase.SaleDate;
                db1.SaveChanges();
                lstPurchase.Items.Refresh();
            }
        }
    }
}
