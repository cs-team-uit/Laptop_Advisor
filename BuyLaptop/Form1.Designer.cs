namespace BuyLaptop
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.btn_query = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_price = new System.Windows.Forms.ComboBox();
            this.cbb_brand = new System.Windows.Forms.ComboBox();
            this.cbb_cpu = new System.Windows.Forms.ComboBox();
            this.cbb_vga = new System.Windows.Forms.ComboBox();
            this.cbb_ram = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Các tiêu chí lựa chọn";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(424, 216);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 3;
            this.btn_query.Text = "Kết quả";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Danh sách laptop:";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(106, 216);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 8;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "VGA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hãng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ram";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mức giá";
            // 
            // cbb_price
            // 
            this.cbb_price.FormattingEnabled = true;
            this.cbb_price.Items.AddRange(new object[] {
            "",
            "Dưới 10",
            "10-15tr",
            "15-20tr",
            "20-25tr"});
            this.cbb_price.Location = new System.Drawing.Point(73, 4);
            this.cbb_price.Name = "cbb_price";
            this.cbb_price.Size = new System.Drawing.Size(121, 21);
            this.cbb_price.TabIndex = 1;
            // 
            // cbb_brand
            // 
            this.cbb_brand.FormattingEnabled = true;
            this.cbb_brand.Items.AddRange(new object[] {
            "",
            "Dell",
            "HP",
            "Lenovo",
            "Acer",
            "Asus"});
            this.cbb_brand.Location = new System.Drawing.Point(73, 27);
            this.cbb_brand.Name = "cbb_brand";
            this.cbb_brand.Size = new System.Drawing.Size(121, 21);
            this.cbb_brand.TabIndex = 1;
            // 
            // cbb_cpu
            // 
            this.cbb_cpu.FormattingEnabled = true;
            this.cbb_cpu.Items.AddRange(new object[] {
            "",
            "Celeron",
            "i3",
            "i5",
            "i7"});
            this.cbb_cpu.Location = new System.Drawing.Point(73, 52);
            this.cbb_cpu.Name = "cbb_cpu";
            this.cbb_cpu.Size = new System.Drawing.Size(121, 21);
            this.cbb_cpu.TabIndex = 1;
            // 
            // cbb_vga
            // 
            this.cbb_vga.FormattingEnabled = true;
            this.cbb_vga.Items.AddRange(new object[] {
            "Không chọn",
            "GT820M",
            "GT840M",
            "GT920M",
            "GT930M",
            "GT940M",
            "GT950M",
            "GTX 850M",
            "GTX 950M",
            "GTX 960M"});
            this.cbb_vga.Location = new System.Drawing.Point(73, 77);
            this.cbb_vga.Name = "cbb_vga";
            this.cbb_vga.Size = new System.Drawing.Size(121, 21);
            this.cbb_vga.TabIndex = 1;
            // 
            // cbb_ram
            // 
            this.cbb_ram.FormattingEnabled = true;
            this.cbb_ram.Items.AddRange(new object[] {
            "",
            "2GB",
            "4GB",
            "6GB",
            "8GB",
            "12GB",
            "16GB"});
            this.cbb_ram.Location = new System.Drawing.Point(73, 100);
            this.cbb_ram.Name = "cbb_ram";
            this.cbb_ram.Size = new System.Drawing.Size(121, 21);
            this.cbb_ram.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_ram);
            this.panel1.Controls.Add(this.cbb_vga);
            this.panel1.Controls.Add(this.cbb_cpu);
            this.panel1.Controls.Add(this.cbb_brand);
            this.panel1.Controls.Add(this.cbb_price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(33, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 144);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 147);
            this.listBox1.TabIndex = 9;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 254);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Main";
            this.Text = "Tư vấn mua laptop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_price;
        private System.Windows.Forms.ComboBox cbb_brand;
        private System.Windows.Forms.ComboBox cbb_cpu;
        private System.Windows.Forms.ComboBox cbb_vga;
        private System.Windows.Forms.ComboBox cbb_ram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
	}
}

