using Database_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

namespace Database_CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoonerCoContext db = new SoonerCoContext();
        private bool ShouldLoadToys = false;
        private bool ShouldLoadDogs = false;
        private bool ShouldLoadOwners = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, RoutedEventArgs e)
        {
            LoadToys(ShouldLoadToys);
            LoadDogs(ShouldLoadDogs);
            LoadOwners(ShouldLoadOwners);

            DisplayDBCont();
        }

        private void DisplayDBCont()
        {
            lstDogs.Items.Clear();
            lstToys.Items.Clear();
            lstDogToys.Items.Clear();


            foreach (var item in db.Dogs.Include(x => x.Owner))
            {
                lstDogs.Items.Add(item);
            }
            foreach (var item in db.Toys)
            {
                lstToys.Items.Add(item);
            }
            foreach (var item in db.DogToys.Include(x => x.Dog).Include(y => y.Toy))
            {
                lstDogToys.Items.Add(item);
            }
        }
        private void LoadOwners(bool load)
        {
            if (load == false) return;

            string ownerInputJson = File.ReadAllText("Owners.json");
            var owners = JsonConvert.DeserializeObject<List<OwnerInput>>(ownerInputJson);

            foreach (var owner in owners)
            {
                db.Owners.Add(new Owner(owner));
            }
            db.SaveChanges();
        }

        private void LoadDogs(bool load)
        {
            if (load == false) return;

            string dogInputJson = File.ReadAllText("Dogs.json");
            var dogs = JsonConvert.DeserializeObject<List<DogInput>>(dogInputJson);

            foreach (var dog in dogs)
            {
                db.Dogs.Add(new Dog(dog));
            }
            db.SaveChanges();
        }

        private void LoadToys(bool load)
        {
            if (load == false) return;

            string toyInputJson = File.ReadAllText("Toys.json");
            var toys = JsonConvert.DeserializeObject<List<ToyInput>>(toyInputJson);

            foreach( var toy in toys)
            {
                db.Toys.Add(new Toy(toy));
            }
            db.SaveChanges();
        }

        private void lstToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selected = (Toy)lstToys.SelectedItem;
            if (selected == null) return;
            imgToy.Source = new BitmapImage(new Uri(selected.Image));
        }

        private void lstDogs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dog selected = (Dog)lstDogs.SelectedItem;
            if (selected == null) return;
            imgDog.Source = new BitmapImage(new Uri(selected.Image));

            lblOwner.Content = $"{selected.Name} is owned by {selected.Owner.Name}";
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            Dog selectedDog = (Dog)lstDogs.SelectedItem;
            Toy selectedToy = (Toy)lstToys.SelectedItem;

            if (selectedDog == null || selectedToy == null) return;

            DogToy dt = new DogToy()
            {
                DogId = selectedDog.Id,
                ToyId = selectedToy.Id
            };

            db.DogToys.Add(dt);
            db.SaveChanges();

            DisplayDBCont();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DogToy selectedDog = (DogToy)lstDogToys.SelectedItem;

            db.DogToys.Remove(selectedDog);
            db.SaveChanges();

            DisplayDBCont();
        }

        private void btnShare_Click(object sender, RoutedEventArgs e)
        {
            DogToy selectedDogToy = (DogToy)lstDogToys.SelectedItem;
            Dog selectedDog = (Dog)lstDogs.SelectedItem;

            if (selectedDogToy == null || selectedDog == null) return;

            var updatedToy = db.DogToys.Find(selectedDogToy.Id);
            updatedToy.DogId = selectedDog.Id;

            db.SaveChanges();

            DisplayDBCont();
        }
    }
}
