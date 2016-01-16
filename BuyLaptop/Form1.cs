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
        int isLoad = 0; 
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
            isLoad = 1;
		}

		private void btn_query_Click(object sender, EventArgs e)
		{
            if (isLoad == 0)
            {
                MessageBox.Show("Vui lòng load tập luật Prolog trước khi thực thi!");
                return;
            }
            if ((!rbnAskBrandN.Checked && !rbnAskBrandY.Checked) || (!rbnPrice.Checked && !rbnSpecs.Checked && !rbnFashion.Checked) ||(!rbnPHIGH.Checked && !rbnPLOW.Checked ))
            {
                MessageBox.Show("Vui lòng chọn các tiêu chí quan tâm!");
                return;
            }
            if (rbnAskBrandY.Checked && (!rbnACER.Checked && !rbnASUS.Checked && !rbnDELL.Checked && !rbnHP.Checked && !rbnLENOVO.Checked))
            {
                MessageBox.Show("Vui lòng chọn các hãng quan tâm!");
                return;
            }
            else
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
                    word.Replace(" ", string.Empty);
                    int msubword = 0;
                    string[] subword = word.Split(' ');
                    if (word.Length != 5)
                    {                 
                        for (int i = 0; i < subword.Length; i++)
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
                    }
                    try
                    {
                        string _result;
                        if (word.Length != 5)
                            _result = subword[msubword];
                        else
                            _result = word;
                        string _priceCondition = "";
                        //[121]
                        switch (_result[3] - 48)
                        {
                            case 1:
                                _priceCondition = "price>=0 and price<=10000";
                                break;
                            case 2:
                                _priceCondition = "price>10000 and price<20000";
                                break;
                        }
                        string sql;
                        sql = "select * from product where brand=\"" + BuyLaptop.Resources.Statics.Brand[_result[1] - 49] + "\" and type=\"" +
                           BuyLaptop.Resources.Statics.Type[_result[2] - 49] + "\" and " + _priceCondition +"";
                        DataTable _queryResult = m_database.GetDataTable(sql);
                        

                        if (_queryResult.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm phù hợp!!!");
                            return;
                        }
                        else
                        {
                            for (int i = 0; i < _queryResult.Rows.Count; i++)
                            {
                                object[] _itemArray = _queryResult.Rows[i].ItemArray;

                                string _itemRow = _currentProduct++ + ". " + _itemArray[1].ToString() + " - " + _itemArray[2].ToString() + " - CPU:" + _itemArray[4].ToString() + " - RAM:" + _itemArray[8].ToString() + " - HDD:" + _itemArray[3].ToString() + " - VGA:" + _itemArray[5].ToString() + " - Size:" + _itemArray[6].ToString() + " - Gia:" + _itemArray[7].ToString();
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
