using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaffePoltekSSN
{
    public partial class Form2 : Form
    {
        private List<User> _userlist = new();

        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pass = textBox2.Text;

            var result = _userlist.FirstOrDefault(x => x.Username == uname);
            if (result != null)
            {
                if (result.Password == pass)
                {
                    MessageBox.Show("Berhasil Login");
                    if (result.Rule == "user")
                    {
                        Form1 form1 = new(result.Username);
                        this.Hide();
                        form1.Show();
                        form1.Closed += (s, args) => this.Close();
                    }
                    else
                    {
                        Form3 form3 = new(result.Username);
                        this.Hide();
                        form3.Show();
                        form3.Closed += (s, args) => this.Close();
                    }                    
                }
                else
                {
                    MessageBox.Show("Password Salah");
                }
            }
            else
            {
                MessageBox.Show("User tidak ditemukan");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _userlist.Add(new User("admin", "pass", "admin"));
            _userlist.Add(new User("user", "pass", "user"));
        }
    }
}
