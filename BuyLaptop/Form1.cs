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
using System.Data.SQLite;

namespace BuyLaptop
{
	public partial class frm_Main : Form
	{
		Connect_Prolog.ConnectProlog connect;
		Resources m_resources;

		SQLiteDatabase m_database;

		public frm_Main()
		{
			connect = new ConnectProlog();
			InitializeComponent();

			m_resources = new Resources();
			m_database = new SQLiteDatabase("laptop.s3db");
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
			listBox1.Items.Clear();

			string price;
			string brand;
			string cpu;
			string vga;
			string size;
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

			if (cbb_size.SelectedIndex == 0 || cbb_size.SelectedIndex == -1)
				size = "_";
			else
				size = cbb_size.SelectedIndex.ToString();

			if (cbb_size.SelectedIndex == -1)
				vga = "_";
			else
				vga = cbb_size.SelectedIndex.ToString();



			query = "laptop(" + price + "," + brand + "," + cpu + "," + vga + "," + size + ",X).";
			String s = connect.Query(query);
			string[] words = s.Split(';');

			int _currentProduct = 1;

			foreach (string word in words)
			{
				if (word == " ")
					continue;

				int msubword = 0;
				string[] subword = word.Split(' ');
				for (int i = 0; i < 3; i++)
				{
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
				}

				try
				{
					string _result = subword[msubword];
					string _priceCondition = "";

					switch(_result[0] - 48)
					{
						case 1:
							_priceCondition = "price between 0 and 10000000";
							break;
						case 2:
							_priceCondition = "price between 10000000 and 15000000";
							break;
						case 3:
							_priceCondition = "price between 15000000 and 20000000";
							break;
						case 4:
							_priceCondition = "price between 20000000 and 25000000";
							break;
					}

					string sql = "select * from product where brand=\"" + Statics.Brand[_result[1] - 49] + "\" and cpu=\"" +
						Statics.CPU[_result[2] - 49] + "\" and vga=\"" + Statics.VGA[_result[3] - 48] + "\" and size=\"" + Statics.ScreenSize[_result[4] - 49] + "\"";

					DataTable _queryResult = m_database.GetDataTable(sql);
					
					if(_queryResult.Rows.Count == 0)
					{
						//MessageBox.Show("Không tìm thấy sản phẩm phù hợp!!!");
					}
					else
					{
						for (int i = 0; i < _queryResult.Rows.Count; i++)
						{
							object[] _itemArray = _queryResult.Rows[i].ItemArray;

							string _itemRow =  _currentProduct++ + ". " + _itemArray[1].ToString() + " - " + _itemArray[2].ToString() + " - " +_itemArray[4].ToString() + " - " + _itemArray[7].ToString() + " - " + _itemArray[8].ToString();
							listBox1.Items.Add(_itemRow);
						}
					}
				}
				catch
				{
					//MessageBox.Show("Không tìm thấy luật phù hợp!!!");
				}
			}
		}
	}
}
