using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace APIPart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://api.chucknorris.io/jokes/categories";

            HttpClient client = new HttpClient();

            string result = client.GetStringAsync(url).Result;

            cmbCat.Items.Add("All");
            cmbCat.SelectedIndex = 0;

            foreach (var item in Newtonsoft.Json.JsonConvert.DeserializeObject < string[]>(result))
            {
                cmbCat.Items.Add(item);
            }
            client.Dispose();
        }

        private void cmbCat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string url = "https://api.chucknorris.io/jokes/random";

            HttpClient client = new HttpClient();

            if (cmbCat.SelectedIndex > 0)
            {
                url += "?category=" + cmbCat.SelectedItem.ToString();
            }

            string result = client.GetStringAsync(url).Result;

            Joke joke = Newtonsoft.Json.JsonConvert.DeserializeObject<Joke>(result);

            txtJoke.Text = joke.value;

        }
    }
}
