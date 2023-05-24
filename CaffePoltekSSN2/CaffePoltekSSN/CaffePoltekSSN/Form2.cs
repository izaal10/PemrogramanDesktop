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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "user" && password == "123")
            {
                //declare form1
                Form1 form1 = new Form1();

                //close login form
                this.Hide();

                //go to form1
                form1.ShowDialog();

                this.Show();
            }
            else if (username == "admin" && password == "123")
            {
                // Create Form3 for user
                Form3 form3 = new Form3();

                // Hide the login form
                this.Hide();

                // Show Form3
                form3.ShowDialog();

                // After Form3 is closed, show the login form again
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
