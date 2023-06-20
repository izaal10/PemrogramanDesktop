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
    public partial class Form4 : Form
    {
        private string username;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string username)
        {
            this.username = username;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
