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

namespace FromAFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CarOwner> carOwners = new List<CarOwner>();
        List<string> distcolor = new List<string>();
        public MainWindow()
        {
            InitializeComponent();


            PopulateListBox();
            Populatecf();
            lstCar.Items.Clear();
        }

        private void PopulateListBox()
        {
            string json = File.ReadAllText("Mock_Data_Car_Owners.json");

            carOwners = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CarOwner>>(json);

            foreach (CarOwner carOwner in carOwners)
            {
                lstCar.Items.Add(carOwner);
            }
        }

        private void Populatecf()
        {

            foreach (CarOwner carOwner in carOwners)
            {
                if (!distcolor.Contains(carOwner.Color))
                {
                    distcolor.Add(carOwner.Color);
                }               
            }
            foreach (var c in distcolor)
            {
                cmbColor.Items.Add(c);
            }
        }

        private void cmbColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string color = cmbColor.SelectedItem.ToString();

            foreach (CarOwner car in carOwners)
            {
                if (car.Color.ToLower() == color.ToLower())
                {
                    lstCar.Items.Add(car);
                }
            }
        }
    }
}
