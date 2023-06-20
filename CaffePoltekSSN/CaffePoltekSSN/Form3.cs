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

namespace CaffePoltekSSN
{
    public partial class Form3 : Form
    {
        private string username;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form2 form2 = new();
            this.Hide();
            form2.Show();
            form2.Closed += (s, args) => this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Halo, " + username;
        }
    }
}
