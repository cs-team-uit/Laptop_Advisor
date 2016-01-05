using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connect_Prolog;

namespace BuyLaptop
{
    public partial class frm_Main : Form
    {
		Connect_Prolog.ConnectProlog connect;
		public frm_Main()
        {
			connect = new ConnectProlog();
			InitializeComponent();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			op.Filter = "Prolog file|*.pl";
			op.ShowDialog();
			String FilePath = op.FileName;
			connect.Load_file(FilePath);
			MessageBox.Show("Load file success !");
			this.btn_query.Enabled = true;
		}

		private void btn_query_Click(object sender, EventArgs e)
		{
            string price ;
            string brand;
            string cpu;
            string vga;
            string ram ;
            string query;
            if (cbb_price.SelectedIndex == 0 || cbb_price.SelectedIndex == -1)
                price = "_";
            else
                price = cbb_price.SelectedIndex.ToString();

            if (cbb_brand.SelectedIndex == 0 || cbb_brand.SelectedIndex == -1)
                brand = "_";
            else
                brand = cbb_brand.SelectedIndex.ToString();

            if (cbb_cpu.SelectedIndex == 0 || cbb_cpu.SelectedIndex == -1)
                cpu = "_";
            else
                cpu = cbb_cpu.SelectedIndex.ToString();

            if (cbb_ram.SelectedIndex == 0 || cbb_ram.SelectedIndex == -1)
                ram = "_";
            else
                ram = cbb_ram.SelectedIndex.ToString();

            if (cbb_ram.SelectedIndex == -1)
                vga = "_";
            else
                vga = cbb_ram.SelectedIndex.ToString();

            

            query = "laptop(" + price + "," + brand + "," + cpu + "," + vga + "," + ram + ",X).";
			String s = connect.Query(query);
            string[] words = s.Split(';');
            foreach (string word in words)
            {
                int msubword = 0;
                string[] subword = word.Split(' ');
                for (int i = 0; i < 3;i++ )
                    try
                    {
                        if (subword[i].Length == 0x00000005)
                        {
                            msubword = i;
                            break;
                        }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        break;
                    }
                    switch (subword[msubword])
                    {
                        case "11111":
                            listBox1.Items.Add("Duoi 10 trieu, dell, celeron, 14 inch, ram 2gb, khong card vga, o cung");
                            break;
                        default:
                            return;
                    }
            }
		}
	}
}
