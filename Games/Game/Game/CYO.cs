using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Game
{
    public partial class CYO : Form
    {
        public CYO()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CYO_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Catcher_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Catchie_Click(object sender, EventArgs e)
        {

        }

        private void Drop1_Click(object sender, EventArgs e)
        {

        }

        private void Drop2_Click(object sender, EventArgs e)
        {

        }

        private void Drop3_Click(object sender, EventArgs e)
        {
        }
        private void upcatch_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files(*.*)|*.*";

                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = open.FileName;

                    Catchie.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void upmean_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files(*.*)|*.*";

                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = open.FileName;

                    Meanie.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updrop1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files(*.*)|*.*";

                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = open.FileName;

                    Drop2.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updrop2_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files(*.*)|*.*";

                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = open.FileName;

                    Drop1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updrop3_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files(*.*)|*.*";

                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = open.FileName;

                    Drop3.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            CYOGame cy = new CYOGame();

            cy.Show();
        }
    }
}
