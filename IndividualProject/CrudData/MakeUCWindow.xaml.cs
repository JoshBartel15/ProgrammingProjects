
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
    /// Interaction logic for MakeUCWindow.xaml
    /// </summary>
    public partial class MakeUCWindow : Window
    {
        DB_128040_bart0146Context db = new DB_128040_bart0146Context();
        public Make make;

        public MakeUCWindow(Make m)
        {
            InitializeComponent();

                btnUpdateMake.Visibility = Visibility.Visible;
                btnGetMake.Visibility = Visibility.Visible;
                btnCreate.Visibility = Visibility.Hidden;

        }

        public MakeUCWindow()
        {
            InitializeComponent();

            btnUpdateMake.Visibility = Visibility.Hidden;
            btnCreate.Visibility = Visibility.Visible;
            btnGetMake.Visibility = Visibility.Hidden;
        }

        private void btnUpdateMake_Click(object sender, RoutedEventArgs e)
        {
            //update the make in the database
            if (make != null)
            {
                make.Make1 = txtName.Text;
                make.Ceo = txtCEO.Text;
                make.Website = txtWeb.Text;
                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MessageBox.Show("Please enter a valid year");
                    return;
                }
                make.FoundedYear = year;
                MessageBox.Show("Make updated");
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            DB_128040_bart0146Context db1 = new DB_128040_bart0146Context();
            {

                Make make = new Make();

                make.Make1 = txtName.Text;
                make.Ceo = txtCEO.Text;
                make.Website = txtWeb.Text;
                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MessageBox.Show("Please enter a valid year");
                    return;
                }
                make.FoundedYear = year;
                db1.Makes.Add(make);
                db1.SaveChanges();
                MessageBox.Show("Make created");
                this.Close();
            }
        }

        private void btnGetMake_Click(object sender, RoutedEventArgs e)
        {
            //populate the textboxes with the selected make
            if (make != null)
            {
                txtName.Text = make.Make1;
                txtCEO.Text = make.Ceo;
                //convert the foundedyear from int to a string using an if tryparse
                txtYear.Text = make.FoundedYear.ToString();
                txtWeb.Text = make.Website;
            }
        }
    }
}
