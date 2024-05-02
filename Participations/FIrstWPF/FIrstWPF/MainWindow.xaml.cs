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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FIrstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnt_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student();
            s.Name = txtFN.Text;
            s.Birthdate = Convert.ToDateTime(dprBday.SelectedDate);
            MessageBox.Show(s.Name + " is " + s.CalculateAge() + " years old.");

            List<Student> students = new List<Student>();
            students.Add(s);
            txtFN.Clear();
            dprBday.SelectedDate = null;
            txtFN.Focus();
        }

        private void btnEnt_MouseEnter(object sender, MouseEventArgs e)
        {
           
            Grid.Background = Brushes.LightBlue;
        }
    }
}
