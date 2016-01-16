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
		SQLiteConnection m_dbConnection;

        Resources m_resources;

        SQLiteDatabase m_database;

		public frm_Main()
        {
			connect = new ConnectProlog();
			InitializeComponent();

			m_resources = new Resources();
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
            string brand = "";
            string type = "";
            string price = "";
            string query = "";
            if (rbnDELL.Checked)
                brand = "dell";
            else if (rbnHP.Checked)
                brand = "hp";
            else if (rbnLENOVO.Checked)
                brand = "lenovo";
            else if (rbnASUS.Checked)
                brand = "asus";
            else if (rbnACER.Checked)
                brand = "acer";

            if (rbnPrice.Checked)
                type = "price";
            else if (rbnFashion.Checked)
                type = "fashion";
            else if (rbnSpecs.Checked)
                type = "specs";

            if (rbnPLOW.Checked)
                price = "low";
            else
                price = "high";
            try
            {
                if (rbnAskBrandY.Checked)
                    query = "laptop(" + brand + "," + type + "," + price + ",X).";
                else if (rbnAskBrandN.Checked)
                    query = "laptop("+type + "," + price + ",X).";
			    String s = connect.Query(query);
			    string[] words = s.Split(';');

			    int _currentProduct = 1;

                foreach (string word in words)
                {
                    if (word == " ")
                        continue;
                    int msubword = 0;
                    string[] subword = word.Split(' ');
                    if (word.Length != 6)
                    {                 
                        for (int i = 0; i < 3; i++)
                        {
                            try
                            {
                                if (subword[i].Length == 0x00000003)
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
                    }
                    try
                    {
                        string _result;
                        if (word.Length != 6)
                            _result = subword[msubword];
                        else
                            _result = word;
                        string _priceCondition = "";
                        //[121]
                        switch (_result[3] - 48)
                        {
                            case 1:
                                _priceCondition = "price between 0 and 10000000";
                                break;
                            case 2:
                                _priceCondition = "price between 10000000 and 20000000";
                                break;
                        }

                        string sql = "select * from product where brand=\"" + BuyLaptop.Resources.Statics.Brand[_result[1] - 49] + "\" and type=\"" +
                            BuyLaptop.Resources.Statics.Type[_result[2] - 49] + "\"";

                        DataTable _queryResult = m_database.GetDataTable(sql);

                        if (_queryResult.Rows.Count == 0)
                        {
                            //MessageBox.Show("Không tìm thấy sản phẩm phù hợp!!!");
                        }
                        else
                        {
                            for (int i = 0; i < _queryResult.Rows.Count; i++)
                            {
                                object[] _itemArray = _queryResult.Rows[i].ItemArray;

                                string _itemRow = _currentProduct++ + ". " + _itemArray[1].ToString() + " - " + _itemArray[2].ToString() + " - " + _itemArray[4].ToString() + " - " + _itemArray[7].ToString() + " - " + _itemArray[8].ToString();
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
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Lỗi truy vấn, vui lòng kiểm tra lại file luật!");
            }

		}
	}
}
