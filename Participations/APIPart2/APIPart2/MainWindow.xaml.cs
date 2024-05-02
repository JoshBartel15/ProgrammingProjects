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

namespace APIPart2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var client = new HttpClient())
            {

                string url = "https://pokeapi.co/api/v2/pokemon?limit=1300";
                string json = client.GetStringAsync(url).Result;

                PokeList pokeList = Newtonsoft.Json.JsonConvert.DeserializeObject<PokeList>(json);

                foreach (Pokemon poke in pokeList.results)
                {
                    lstPoke.Items.Add(poke);
                }
            }
        }

        private void lstPoke_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                Pokemon selectedPoke = (Pokemon)lstPoke.SelectedItem;
                string url = "https://pokeapi.co/api/v2/pokemon/" + selectedPoke.name;
                string json = client.GetStringAsync(url).Result;
                Poke poke = Newtonsoft.Json.JsonConvert.DeserializeObject<Poke>(json);

                txtHeight .Text = $"Height {poke.height.ToString()}";
                txtWeight.Text = $"Weight = {poke.weight.ToString()}";
                imgPoke.Source = new BitmapImage(new Uri(poke.sprites.front_default));
            }
        }
    }
}
