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
    public partial class Form1 : Form
    {
		Connect_Prolog.ConnectProlog connect;
		public Form1()
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
			string query = cbb_price.SelectedIndex+ "," + cbb_brand.SelectedIndex + "," + cbb_cpu.SelectedIndex;
			String s = connect.Query(query);
		}
	}
}
