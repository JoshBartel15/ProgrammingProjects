using PartDatabase.Models;
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

namespace PartDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            populatecsbox();
            populatesbox();
        }

        private void populatesbox()
        {
            DB_128040_practiceContext db = new DB_128040_practiceContext();
            foreach (var item in db.Students)
            {
                lstStudent.Items.Add(item.FirstName + " " + item.LastName);
            }
        }

        private void populatecsbox()
        {
            DB_128040_practiceContext db = new DB_128040_practiceContext();
            foreach (var item in db.Courses)
            {
                lstCourse.Items.Add(item.CourseName);
            }
        }

        private void lstStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //show student data in messageboxes
            DB_128040_practiceContext db = new DB_128040_practiceContext();
            var student = db.Students.FirstOrDefault(s => s.FirstName + " " + s.LastName == lstStudent.SelectedItem.ToString());
            MessageBox.Show(student.FirstName + " " + student.LastName + "\n" + student.FavoriteColor);
        }

        private void lstCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //show course data in messageboxes
            DB_128040_practiceContext db = new DB_128040_practiceContext();
            var course = db.Courses.FirstOrDefault(c => c.CourseName == lstCourse.SelectedItem.ToString());
            MessageBox.Show(course.CourseName + "\n" + course.CourseNumber);
        }
    }
}
