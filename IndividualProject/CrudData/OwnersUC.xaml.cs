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
    /// Interaction logic for OwnersUC.xaml
    /// </summary>
    public partial class OwnersUC : Window
    {
        DB_128040_bart0146Context db = new DB_128040_bart0146Context();
        public Owner owner;

        public OwnersUC(Owner o)
        {
            InitializeComponent();

            btnUpdate.Visibility = Visibility.Visible;
            btnGetOwner.Visibility = Visibility.Visible;
            btnCreate.Visibility = Visibility.Hidden;
        }
        public OwnersUC()
        {
            InitializeComponent();

                btnUpdate.Visibility = Visibility.Hidden;
                btnCreate.Visibility = Visibility.Visible;
                btnGetOwner.Visibility = Visibility.Hidden;
            
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            //create a new owner
            using (DB_128040_bart0146Context db = new DB_128040_bart0146Context())
            {
                Owner owner = new Owner();
                owner.Name = txtName.Text;
                db.Owners.Add(owner);
                db.SaveChanges();
                MessageBox.Show("Owner created");
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(owner != null)
            {
                owner.Name = txtName.Text;
                MessageBox.Show("Owner updated");
                this.Close();
            }
        }

        private void btnGetOwner_Click(object sender, RoutedEventArgs e)
        {
            if (owner != null)
            {
                txtName.Text = owner.Name;
            }
        }
    }
}
