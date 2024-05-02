using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }


        private void Start_Click(object sender, EventArgs e)
        {
            Select gamescreen = new Select();

            gamescreen.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
