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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CrudData
{
    /// <summary>
    /// Interaction logic for OwnersMain.xaml
    /// </summary>
    public partial class OwnersMain : Window
    {
        public OwnersMain()
        {
            InitializeComponent();

            using (DB_128040_bart0146Context db1 = new DB_128040_bart0146Context())
            {
                List<Owner> owners = db1.Owners.ToList();
                foreach (Owner owner in owners)
                {
                    lstOwners.Items.Add(owner);
                }
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            OwnersUC ownersUC = new OwnersUC((Owner)lstOwners.SelectedItem);
            ownersUC.owner = (Owner)lstOwners.SelectedItem;
            if (ownersUC.owner == null)
            {
                MessageBox.Show("Please select an owner");
                return;
            }
            ownersUC.ShowDialog();
            using (DB_128040_bart0146Context db2 = new DB_128040_bart0146Context())
            {
                Owner owner = db2.Owners.Where(o => o.OwnerId == ownersUC.owner.OwnerId).FirstOrDefault();
                owner.Name = ownersUC.owner.Name;
                db2.SaveChanges();
                lstOwners.Items.Clear();
                List<Owner> owners = db2.Owners.ToList();
                foreach (Owner owner1 in owners)
                {
                    lstOwners.Items.Add(owner1);
                }
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            OwnersUC ownersUC = new OwnersUC();
            ownersUC.ShowDialog();
            MessageBox.Show("Owner created");
            lstOwners.Items.Clear();
            using (DB_128040_bart0146Context db1 = new DB_128040_bart0146Context())
            {
                foreach (var item in db1.Owners)
                {
                    lstOwners.Items.Add(item);
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            using (DB_128040_bart0146Context db = new DB_128040_bart0146Context())
            {
                Owner selectedOwner = (Owner)lstOwners.SelectedItem;
                if (selectedOwner == null)
                {
                    MessageBox.Show("Please select an owner to delete");
                    return;
                }
                db.Owners.Remove(selectedOwner);
                var purchases = db.Purchases.Where(p => p.OwnerId == selectedOwner.OwnerId);
                foreach (var purchase in purchases)
                {
                    db.Purchases.Remove(purchase);
                }
                db.SaveChanges();
                lstOwners.Items.Remove(selectedOwner);
            }
        }
    }
}
