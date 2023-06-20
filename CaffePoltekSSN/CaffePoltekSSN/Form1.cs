namespace CaffePoltekSSN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            this.Close();
        }
    }
}