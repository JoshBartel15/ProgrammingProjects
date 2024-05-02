using Microsoft.Win32;
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
using Newtonsoft.Json;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Cars> cars = new List<Cars>();
        List<Owner> owns = new List<Owner>();
        List<Make> makes = new List<Make>();
        OpenFileDialog ofd = new OpenFileDialog();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnOF_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads";
            ofd.InitialDirectory = path;
            ofd.Filter = "Comma Separated Value documents (.csv)|*.csv;";
            ofd.ShowDialog();
            var lines = File.ReadAllLines(ofd.FileName).Skip(1);

            foreach (string line in lines)
            {
                cars.Add(new Cars(line));
            }
            foreach (var item in cars)
            {
                foreach (var owner in item.Owners)
                {
                    owns.Add(owner);
                }
                makes.Add(item.Make);
            }
            PopulateMakeListBox();
            PopulateOwnerListBox();
            PopulateCT();
        }
        private void PopulateCT()
        {
            foreach (var item in cars)
            {
                lstct.Items.Add(item);
            }
        }

        private void PopulateMakeListBox()
        {
            foreach (var item in makes.OrderBy(x => x.make))
            {
                if (!lstMake.Items.Contains(item))
                {
                    lstMake.Items.Add(item);
                }

            }
        }
        private void PopulateOwnerListBox()
        {
            var owner = owns.OrderBy(x => x.name);
            foreach (var item in owner)
            {
                if (!lstOwner.Items.Contains(item.name))
                {
                    lstOwner.Items.Add(item.ToString());
                }
            }
        }
        private void btnCSV_Click(object sender, RoutedEventArgs e)
        {
            var csv = new StringBuilder();
            csv.AppendLine("VIN,Year,Make,Model,Owners,Color,Type");
            foreach (var item in lstct.Items)
            {
                var newLine = string.Format("{0}", item);
                csv.AppendLine(newLine);
            }
            File.WriteAllText("FixedUsedCars.csv", csv.ToString());

            var csvmake = new StringBuilder();
            csvmake.AppendLine("Make,CEO,FoundedYear,Website");
            foreach (var item in lstMake.Items)
            {
                var newLine = string.Format("{0}", item);
                csvmake.AppendLine(newLine);
            }
            File.WriteAllText("Make.csv", csvmake.ToString());

            var csvowner = new StringBuilder();
            csvowner.AppendLine("Name");
            foreach (var item in lstOwner.Items)
            {
                var newLine = string.Format("{0}", item);
                csvowner.AppendLine(newLine);
            }
            File.WriteAllText("Owner.csv", csvowner.ToString());

            MessageBox.Show("CSV files created");
        }

        private void btnJSON_Click(object sender, RoutedEventArgs e)
        {
            var json = JsonConvert.SerializeObject(lstct.Items,Formatting.Indented);
            File.WriteAllText("UsedCars.json", json);

            var jsonmake = JsonConvert.SerializeObject(lstMake.Items,Formatting.Indented);
            File.WriteAllText("Make.json", jsonmake);

            var jsonowner = JsonConvert.SerializeObject(lstOwner.Items,Formatting.Indented);
            File.WriteAllText("Owner.json", jsonowner);

            MessageBox.Show("JSON files created");
        }
    }
}
