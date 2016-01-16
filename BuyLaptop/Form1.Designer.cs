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
            this.btn_query = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbnAskBrandY = new System.Windows.Forms.RadioButton();
            this.rbnAskBrandN = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnDELL = new System.Windows.Forms.RadioButton();
            this.rbnHP = new System.Windows.Forms.RadioButton();
            this.rbnLENOVO = new System.Windows.Forms.RadioButton();
            this.rbnASUS = new System.Windows.Forms.RadioButton();
            this.rbnACER = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbnPHIGH = new System.Windows.Forms.RadioButton();
            this.rbnPLOW = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbnSpecs = new System.Windows.Forms.RadioButton();
            this.rbnPrice = new System.Windows.Forms.RadioButton();
            this.rbnFashion = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_load.Location = new System.Drawing.Point(12, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 8;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(333, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(438, 147);
            this.listBox1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnAskBrandN);
            this.panel1.Controls.Add(this.rbnAskBrandY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 46);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbnACER);
            this.panel2.Controls.Add(this.rbnASUS);
            this.panel2.Controls.Add(this.rbnLENOVO);
            this.panel2.Controls.Add(this.rbnHP);
            this.panel2.Controls.Add(this.rbnDELL);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 59);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bạn có quan tâm hãng không?";
            // 
            // rbnAskBrandY
            // 
            this.rbnAskBrandY.AutoSize = true;
            this.rbnAskBrandY.Location = new System.Drawing.Point(6, 25);
            this.rbnAskBrandY.Name = "rbnAskBrandY";
            this.rbnAskBrandY.Size = new System.Drawing.Size(38, 17);
            this.rbnAskBrandY.TabIndex = 12;
            this.rbnAskBrandY.TabStop = true;
            this.rbnAskBrandY.Text = "Có";
            this.rbnAskBrandY.UseVisualStyleBackColor = true;
            // 
            // rbnAskBrandN
            // 
            this.rbnAskBrandN.AutoSize = true;
            this.rbnAskBrandN.Location = new System.Drawing.Point(132, 25);
            this.rbnAskBrandN.Name = "rbnAskBrandN";
            this.rbnAskBrandN.Size = new System.Drawing.Size(56, 17);
            this.rbnAskBrandN.TabIndex = 12;
            this.rbnAskBrandN.TabStop = true;
            this.rbnAskBrandN.Text = "Không";
            this.rbnAskBrandN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nếu có, hãy chọn hãng";
            // 
            // rbnDELL
            // 
            this.rbnDELL.AutoSize = true;
            this.rbnDELL.Location = new System.Drawing.Point(6, 28);
            this.rbnDELL.Name = "rbnDELL";
            this.rbnDELL.Size = new System.Drawing.Size(52, 17);
            this.rbnDELL.TabIndex = 12;
            this.rbnDELL.TabStop = true;
            this.rbnDELL.Text = "DELL";
            this.rbnDELL.UseVisualStyleBackColor = true;
            // 
            // rbnHP
            // 
            this.rbnHP.AutoSize = true;
            this.rbnHP.Location = new System.Drawing.Point(64, 28);
            this.rbnHP.Name = "rbnHP";
            this.rbnHP.Size = new System.Drawing.Size(40, 17);
            this.rbnHP.TabIndex = 12;
            this.rbnHP.TabStop = true;
            this.rbnHP.Text = "HP";
            this.rbnHP.UseVisualStyleBackColor = true;
            // 
            // rbnLENOVO
            // 
            this.rbnLENOVO.AutoSize = true;
            this.rbnLENOVO.Location = new System.Drawing.Point(99, 28);
            this.rbnLENOVO.Name = "rbnLENOVO";
            this.rbnLENOVO.Size = new System.Drawing.Size(69, 17);
            this.rbnLENOVO.TabIndex = 12;
            this.rbnLENOVO.TabStop = true;
            this.rbnLENOVO.Text = "LENOVO";
            this.rbnLENOVO.UseVisualStyleBackColor = true;
            // 
            // rbnASUS
            // 
            this.rbnASUS.AutoSize = true;
            this.rbnASUS.Location = new System.Drawing.Point(174, 28);
            this.rbnASUS.Name = "rbnASUS";
            this.rbnASUS.Size = new System.Drawing.Size(54, 17);
            this.rbnASUS.TabIndex = 12;
            this.rbnASUS.TabStop = true;
            this.rbnASUS.Text = "ASUS";
            this.rbnASUS.UseVisualStyleBackColor = true;
            // 
            // rbnACER
            // 
            this.rbnACER.AutoSize = true;
            this.rbnACER.Location = new System.Drawing.Point(234, 28);
            this.rbnACER.Name = "rbnACER";
            this.rbnACER.Size = new System.Drawing.Size(54, 17);
            this.rbnACER.TabIndex = 12;
            this.rbnACER.TabStop = true;
            this.rbnACER.Text = "ACER";
            this.rbnACER.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbnPHIGH);
            this.panel3.Controls.Add(this.rbnPLOW);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 46);
            this.panel3.TabIndex = 10;
            // 
            // rbnPHIGH
            // 
            this.rbnPHIGH.AutoSize = true;
            this.rbnPHIGH.Location = new System.Drawing.Point(132, 25);
            this.rbnPHIGH.Name = "rbnPHIGH";
            this.rbnPHIGH.Size = new System.Drawing.Size(113, 17);
            this.rbnPHIGH.TabIndex = 12;
            this.rbnPHIGH.TabStop = true;
            this.rbnPHIGH.Text = "Từ 10 đến 20 triệu";
            this.rbnPHIGH.UseVisualStyleBackColor = true;
            // 
            // rbnPLOW
            // 
            this.rbnPLOW.AutoSize = true;
            this.rbnPLOW.Location = new System.Drawing.Point(6, 25);
            this.rbnPLOW.Name = "rbnPLOW";
            this.rbnPLOW.Size = new System.Drawing.Size(85, 17);
            this.rbnPLOW.TabIndex = 12;
            this.rbnPLOW.TabStop = true;
            this.rbnPLOW.Text = "Dưới 10 triệu";
            this.rbnPLOW.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bạn chấp nhận chi trả bao nhiêu?";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbnSpecs);
            this.panel4.Controls.Add(this.rbnPrice);
            this.panel4.Controls.Add(this.rbnFashion);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 59);
            this.panel4.TabIndex = 10;
            // 
            // rbnSpecs
            // 
            this.rbnSpecs.AutoSize = true;
            this.rbnSpecs.Location = new System.Drawing.Point(212, 28);
            this.rbnSpecs.Name = "rbnSpecs";
            this.rbnSpecs.Size = new System.Drawing.Size(67, 17);
            this.rbnSpecs.TabIndex = 12;
            this.rbnSpecs.TabStop = true;
            this.rbnSpecs.Text = "Cấu hình";
            this.rbnSpecs.UseVisualStyleBackColor = true;
            // 
            // rbnPrice
            // 
            this.rbnPrice.AutoSize = true;
            this.rbnPrice.Location = new System.Drawing.Point(112, 28);
            this.rbnPrice.Name = "rbnPrice";
            this.rbnPrice.Size = new System.Drawing.Size(56, 17);
            this.rbnPrice.TabIndex = 12;
            this.rbnPrice.TabStop = true;
            this.rbnPrice.Text = "Giá cả";
            this.rbnPrice.UseVisualStyleBackColor = true;
            // 
            // rbnFashion
            // 
            this.rbnFashion.AutoSize = true;
            this.rbnFashion.Location = new System.Drawing.Point(6, 28);
            this.rbnFashion.Name = "rbnFashion";
            this.rbnFashion.Size = new System.Drawing.Size(76, 17);
            this.rbnFashion.TabIndex = 12;
            this.rbnFashion.TabStop = true;
            this.rbnFashion.Text = "Ngoại hình";
            this.rbnFashion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bạn ưu tiên yếu tố nào?";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 368);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_query);
            this.Name = "frm_Main";
            this.Text = "Tư vấn mua laptop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbnAskBrandN;
        private System.Windows.Forms.RadioButton rbnAskBrandY;
        private System.Windows.Forms.RadioButton rbnACER;
        private System.Windows.Forms.RadioButton rbnASUS;
        private System.Windows.Forms.RadioButton rbnLENOVO;
        private System.Windows.Forms.RadioButton rbnHP;
        private System.Windows.Forms.RadioButton rbnDELL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbnPHIGH;
        private System.Windows.Forms.RadioButton rbnPLOW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbnSpecs;
        private System.Windows.Forms.RadioButton rbnPrice;
        private System.Windows.Forms.RadioButton rbnFashion;
        private System.Windows.Forms.Label label4;
	}
}

