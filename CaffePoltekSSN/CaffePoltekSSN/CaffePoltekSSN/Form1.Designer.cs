namespace CaffePoltekSSN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menucombo = new System.Windows.Forms.Label();
            this.sizecombo = new System.Windows.Forms.Label();
            this.sugarcombo = new System.Windows.Forms.Label();
            this.icecombo = new System.Windows.Forms.Label();
            this.addoncombo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combomenu = new System.Windows.Forms.ComboBox();
            this.combosize = new System.Windows.Forms.ComboBox();
            this.combosugar = new System.Windows.Forms.ComboBox();
            this.comboice = new System.Windows.Forms.ComboBox();
            this.comboaddon = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewmenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sugarlvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icelvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addontopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalharga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.comboqty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(690, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caffe PoltekSSN";
            // 
            // menucombo
            // 
            this.menucombo.AutoSize = true;
            this.menucombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menucombo.Location = new System.Drawing.Point(224, 126);
            this.menucombo.Name = "menucombo";
            this.menucombo.Size = new System.Drawing.Size(62, 28);
            this.menucombo.TabIndex = 1;
            this.menucombo.Text = "Menu";
            // 
            // sizecombo
            // 
            this.sizecombo.AutoSize = true;
            this.sizecombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizecombo.Location = new System.Drawing.Point(224, 186);
            this.sizecombo.Name = "sizecombo";
            this.sizecombo.Size = new System.Drawing.Size(47, 28);
            this.sizecombo.TabIndex = 2;
            this.sizecombo.Text = "Size";
            // 
            // sugarcombo
            // 
            this.sugarcombo.AutoSize = true;
            this.sugarcombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sugarcombo.Location = new System.Drawing.Point(224, 245);
            this.sugarcombo.Name = "sugarcombo";
            this.sugarcombo.Size = new System.Drawing.Size(112, 28);
            this.sugarcombo.TabIndex = 3;
            this.sugarcombo.Text = "Sugar Level";
            // 
            // icecombo
            // 
            this.icecombo.AutoSize = true;
            this.icecombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.icecombo.Location = new System.Drawing.Point(224, 300);
            this.icecombo.Name = "icecombo";
            this.icecombo.Size = new System.Drawing.Size(85, 28);
            this.icecombo.TabIndex = 4;
            this.icecombo.Text = "Ice Level";
            // 
            // addoncombo
            // 
            this.addoncombo.AutoSize = true;
            this.addoncombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addoncombo.Location = new System.Drawing.Point(224, 360);
            this.addoncombo.Name = "addoncombo";
            this.addoncombo.Size = new System.Drawing.Size(163, 28);
            this.addoncombo.TabIndex = 5;
            this.addoncombo.Text = "Add-On/Topping";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(224, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // combomenu
            // 
            this.combomenu.FormattingEnabled = true;
            this.combomenu.Items.AddRange(new object[] {
            "Espresso",
            "Latte",
            "Cappucino"});
            this.combomenu.Location = new System.Drawing.Point(458, 131);
            this.combomenu.Name = "combomenu";
            this.combomenu.Size = new System.Drawing.Size(213, 23);
            this.combomenu.TabIndex = 7;
            // 
            // combosize
            // 
            this.combosize.FormattingEnabled = true;
            this.combosize.Items.AddRange(new object[] {
            "Medium",
            "Large"});
            this.combosize.Location = new System.Drawing.Point(458, 191);
            this.combosize.Name = "combosize";
            this.combosize.Size = new System.Drawing.Size(213, 23);
            this.combosize.TabIndex = 8;
            // 
            // combosugar
            // 
            this.combosugar.FormattingEnabled = true;
            this.combosugar.Items.AddRange(new object[] {
            "100",
            "75",
            "50",
            "0"});
            this.combosugar.Location = new System.Drawing.Point(458, 250);
            this.combosugar.Name = "combosugar";
            this.combosugar.Size = new System.Drawing.Size(213, 23);
            this.combosugar.TabIndex = 9;
            // 
            // comboice
            // 
            this.comboice.FormattingEnabled = true;
            this.comboice.Items.AddRange(new object[] {
            "100",
            "75",
            "50",
            "0"});
            this.comboice.Location = new System.Drawing.Point(458, 305);
            this.comboice.Name = "comboice";
            this.comboice.Size = new System.Drawing.Size(213, 23);
            this.comboice.TabIndex = 10;
            // 
            // comboaddon
            // 
            this.comboaddon.FormattingEnabled = true;
            this.comboaddon.Items.AddRange(new object[] {
            "No Topping",
            "Bubble",
            "Grass Jelly",
            "Nata de coco",
            "Whipped cream",
            "Choco chip",
            "Oreo"});
            this.comboaddon.Location = new System.Drawing.Point(458, 365);
            this.comboaddon.Name = "comboaddon";
            this.comboaddon.Size = new System.Drawing.Size(213, 23);
            this.comboaddon.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(458, 530);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(213, 23);
            this.textTotal.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viewmenu,
            this.SizeCup,
            this.sugarlvl,
            this.Icelvl,
            this.addontopp,
            this.qty,
            this.totalharga});
            this.dataGridView1.Location = new System.Drawing.Point(716, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(747, 142);
            this.dataGridView1.TabIndex = 14;
            // 
            // viewmenu
            // 
            this.viewmenu.HeaderText = "Menu";
            this.viewmenu.Name = "viewmenu";
            // 
            // SizeCup
            // 
            this.SizeCup.HeaderText = "Size";
            this.SizeCup.Name = "SizeCup";
            // 
            // sugarlvl
            // 
            this.sugarlvl.HeaderText = "Sugar Level";
            this.sugarlvl.Name = "sugarlvl";
            // 
            // Icelvl
            // 
            this.Icelvl.HeaderText = "Ice Level";
            this.Icelvl.Name = "Icelvl";
            // 
            // addontopp
            // 
            this.addontopp.HeaderText = "Add-On";
            this.addontopp.Name = "addontopp";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // totalharga
            // 
            this.totalharga.HeaderText = "Total";
            this.totalharga.Name = "totalharga";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboqty
            // 
            this.comboqty.FormattingEnabled = true;
            this.comboqty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboqty.Location = new System.Drawing.Point(458, 420);
            this.comboqty.Name = "comboqty";
            this.comboqty.Size = new System.Drawing.Size(213, 23);
            this.comboqty.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(224, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1011, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Order List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboqty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboaddon);
            this.Controls.Add(this.comboice);
            this.Controls.Add(this.combosugar);
            this.Controls.Add(this.combosize);
            this.Controls.Add(this.combomenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addoncombo);
            this.Controls.Add(this.icecombo);
            this.Controls.Add(this.sugarcombo);
            this.Controls.Add(this.sizecombo);
            this.Controls.Add(this.menucombo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label menucombo;
        private Label sizecombo;
        private Label sugarcombo;
        private Label icecombo;
        private Label addoncombo;
        private Label label7;
        private ComboBox combomenu;
        private ComboBox combosize;
        private ComboBox combosugar;
        private ComboBox comboice;
        private ComboBox comboaddon;
        private Button button1;
        private TextBox textTotal;
        private DataGridView dataGridView1;
        private Button button2;
        private ComboBox comboqty;
        private Label label2;
        private DataGridViewTextBoxColumn viewmenu;
        private DataGridViewTextBoxColumn SizeCup;
        private DataGridViewTextBoxColumn sugarlvl;
        private DataGridViewTextBoxColumn Icelvl;
        private DataGridViewTextBoxColumn addontopp;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn totalharga;
        private Label label3;
    }
}