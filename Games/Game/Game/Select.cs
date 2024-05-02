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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void Bubba_Click(object sender, EventArgs e)
        {
            Form1 bubba = new Form1();

            bubba.Show();
        }

        private void Clay_Click(object sender, EventArgs e)
        {
            Clay clay = new Clay();

            clay.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CYOG_Click(object sender, EventArgs e)
        {
            CYO create = new CYO();

            create.Show();
        }
    }
}
