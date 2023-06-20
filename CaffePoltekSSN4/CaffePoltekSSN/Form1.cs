using QRCoder;
using System.Drawing.Printing;
using System.Formats.Asn1;
using System.Globalization;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;

namespace CaffePoltekSSN
{
    public partial class Form1 : Form
    {
        private string username;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (combomenu.SelectedItem.ToString()=="Espresso")
            {
                if (combosize.SelectedItem.ToString()=="Medium")
                {
                    if (comboaddon.SelectedItem.ToString()== "No Topping")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 10000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Bubble")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 13000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Grass jelly")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 13500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Nata de coco")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 12500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Whipped cream")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 11000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Choco chip")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 11500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Oreo")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 10000).ToString();
                    }
                }
                if (combosize.SelectedItem.ToString() == "Large")
                {
                    if (comboaddon.SelectedItem.ToString() == "No Topping")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 13000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Bubble")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 16000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Grass jelly")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 16500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Nata de coco")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 15500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Whipped cream")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 14000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Choco chip")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 14500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Oreo")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 13000).ToString();
                    }
                }
                dataGridView1.Rows.Add(combomenu.Text, combosize.Text, combosugar.Text, comboice.Text, comboaddon.Text, comboqty.Text, textTotal.Text);
            }
            if (combomenu.SelectedItem.ToString() == "Latte")
            {
                if (combosize.SelectedItem.ToString() == "Medium")
                {
                    if (comboaddon.SelectedItem.ToString() == "No Topping")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 15000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Bubble")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 18000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Grass jelly")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 18500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Nata de coco")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 17500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Whipped cream")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 16000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Choco chip")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 16500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Oreo")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 15000).ToString();
                    }
                }
                if (combosize.SelectedItem.ToString() == "Large")
                {
                    if (comboaddon.SelectedItem.ToString() == "No Topping")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 18000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Bubble")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 21000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Grass jelly")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 21500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Nata de coco")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 20500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Whipped cream")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 19000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Choco chip")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 19500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Oreo")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 18000).ToString();
                    }
                }
                dataGridView1.Rows.Add(combomenu.Text, combosize.Text, combosugar.Text, comboice.Text, comboaddon.Text, comboqty.Text, textTotal.Text);
            }
            if (combomenu.SelectedItem.ToString() == "Cappuccino")
            {
                if (combosize.SelectedItem.ToString() == "Medium")
                {
                    if (comboaddon.SelectedItem.ToString() == "No Topping")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 12000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Bubble")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 15000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Grass jelly")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 15500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Nata de coco")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 14500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Whipped cream")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 13000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Choco chip")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 13500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Oreo")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 12000).ToString();
                    }
                }
                if (combosize.SelectedItem.ToString() == "Large")
                {
                    if (comboaddon.SelectedItem.ToString() == "No Topping")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 15000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Bubble")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 18000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Grass jelly")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 18500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Nata de coco")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 17500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Whipped cream")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 16000).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Choco chip")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 16500).ToString();
                    }
                    if (comboaddon.SelectedItem.ToString() == "Oreo")
                    {
                        textTotal.Text = (float.Parse(comboqty.Text) * 15000).ToString();
                    }
                }
                dataGridView1.Rows.Add(combomenu.Text, combosize.Text, combosugar.Text, comboice.Text, comboaddon.Text, comboqty.Text, textTotal.Text);
                //dt.Rows.Add(combomenu.Text, combosize.Text, combosugar.Text, comboice.Text, comboaddon.Text, comboqty.Text, textTotal.Text);
                //dataGridView1.DataSource = dt;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            combomenu.Text = "";
            combosize.Text = "";
            combosugar.Text = "";
            comboice.Text = "";
            comboaddon.Text = "";
            comboqty.Text = "";
            textTotal.Text = "";
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

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "Halo, " + username;
            //dataGridView1.DataSource = dt;
            //dataGridView1.AllowUserToAddRows = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Cafe PoltekSSN", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new PointF(70, 30));
            e.Graphics.DrawString("-----------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new PointF(10, 60));
            e.Graphics.DrawString(combomenu.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(30, 80));
            e.Graphics.DrawString(combosize.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(30, 100));
            e.Graphics.DrawString(combosugar.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(30, 120));
            e.Graphics.DrawString(comboice.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(30, 140));
            e.Graphics.DrawString(comboaddon.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(30, 160));
            e.Graphics.DrawString(comboqty.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(30, 180));
            e.Graphics.DrawString(textTotal.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(30, 200));
            e.Graphics.DrawString("-----------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new PointF(30, 220));
            e.Graphics.DrawString("Enjoy Your Drink", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new PointF(70, 240));
        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime waktu1 = DateTime.Now;
            var guid = Guid.NewGuid();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            var records = new List<Order>
            {

                new Order {Id=guid, Item = combomenu.Text, Size = combosize.Text, Sugar = combosugar.Text, Ice = comboice.Text, Top = comboaddon.Text, Qty = comboqty.Text, email= textEmail.Text, Waktu=waktu1 },
            };

            using var writer = new StreamWriter("order.csv", append: true);
            using var csv = new CsvWriter(writer, config);
            csv.WriteRecords(records);

            QRCodeGenerator qrGenerator = new();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(guid.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.Image = qrCodeImage;
        }
    }
}