using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BuyLaptop
{
	public class Resources
	{
		SQLiteDatabase m_database;
        public static class Statics
        {
            public static string[] Brand =
		    {
			    "DELL",
			    "HP",
			    "LENOVO",
			    "ASUS",
			    "ACER"
		    };
            public static string[] Type =
		    {
			    "prices",
			    "fashion",
			    "specs",
		    };
          

        }
		public Resources()
		{

            if (System.IO.File.Exists("laptop.s3db"))
                m_database = new SQLiteDatabase("laptop.s3db");
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Database File|*.s3db";
                op.ShowDialog();
                String FilePath = op.FileName;
                m_database = new SQLiteDatabase(FilePath);
            }
			Insert();
		}

		private void Insert()
		{
            m_database.ClearTable("product");
            m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 3543", "500GB", "i3", "No", "15.6", "4GB", "fashion","9999"));
            m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 7348T", "500GB", "i5", "No", "13.3", "8GB", "fashion", "18999"));
            m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 3458", "500GB", "i3", "820M 2GB", "14", "4GB", "specs", "9999"));
            m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 7559", "1000GB", "i5", "GTX960M 4GB", "15.6", "8GB", "specs", "18399"));
            m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 3458-TXTGH2", "500GB", "i3", "No", "14", "4GB", "prices", "9899"));
            m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 5459", "1000GB", "i7", "Radeon R5 M335 4GB", "15.6", "8GB", "prices", "18999"));

            m_database.Insert("product", CreateDictionary("HP", "PAVILION x360", "500GB", "PENTIUM", "No", "11.6", "4GB", "fashion", "9999"));
            m_database.Insert("product", CreateDictionary("HP", "PAVILION 15 ", "1000GB", "i7", "GT940M 2GB", "15", "8GB", "fashion", "16899"));
            m_database.Insert("product", CreateDictionary("HP", "350 G2", "500GB", "i3", "No", "14", "8GB", "specs", "9299"));
            m_database.Insert("product", CreateDictionary("HP", "PAVILION 15 ", "1000GB", "i7", "GT940M 2GB", "15.6", "4GB", "specs", "17899"));
            m_database.Insert("product", CreateDictionary("HP", "PAVILION 14", "500GB", "i3", "No", "14", "4GB", "prices", "9499"));
            m_database.Insert("product", CreateDictionary("HP", "PAVILION 15", "1000GB", "i7", "GT840M 2GB", "15", "4GB", "prices", "15399"));

            m_database.Insert("product", CreateDictionary("LENOVO", "S410", "500GB", "i3", "No", "14", "4GB", "fashion", "9390"));
            m_database.Insert("product", CreateDictionary("LENOVO", "Z5070", "1000GB", "i7", "GT 840M 4GB", "15.6", "4GB", "fashion", "16499"));
            m_database.Insert("product", CreateDictionary("LENOVO", "S410", "500GB", "i3", "No", "14", "4GB", "specs", "9399"));
            m_database.Insert("product", CreateDictionary("LENOVO", "IDEAPAD", "1000GB", "i7", "R7 M360", "14", "4GB", "specs", "16999"));
            m_database.Insert("product", CreateDictionary("LENOVO", "S410", "500GB", "i3", "No", "14", "4GB", "prices", "9399"));
            m_database.Insert("product", CreateDictionary("LENOVO", "Thinkpad E560", "500GB", "i5", "R7 M330 2GB", "15.6", "4GB", "prices", "14999"));

            m_database.Insert("product", CreateDictionary("ASUS", "F200MA", "500GB", "PENTIUM", "No", "11.6", "4GB", "fashion", "8599"));
            m_database.Insert("product", CreateDictionary("ASUS", "K501LX", "1000GB", "i5", "GTX950M 4GB", "15.6", "8GB", "fashion", "15899"));
            m_database.Insert("product", CreateDictionary("ASUS", "K455LD", "500GB", "i3", "GT820M 2GB", "14", "8GB", "specs", "9899"));
            m_database.Insert("product", CreateDictionary("ASUS", "K501LX", "500GB", "i7", "GTX950M 4GB", "15.6", "8GB", "specs", "19299"));
            m_database.Insert("product", CreateDictionary("ASUS", "X554LD", "500GB", "i3", "GT820M 1GB", "15.6", "4GB", "prices", "9599"));
            m_database.Insert("product", CreateDictionary("ASUS", "K501LX", "500GB", "i7", "GTX 950M 4GB", "15.6", "4GB", "prices", "17350"));

            m_database.Insert("product", CreateDictionary("ACER", "Z1402 350L", "500GB", "i3", "No", "14", "4GB", "fashion", "8299"));
            m_database.Insert("product", CreateDictionary("ACER", "E5-574G-59DA", "500GB", "i5", "GT920M 2GB", "15.6", "4GB", "fashion", "12699"));
            m_database.Insert("product", CreateDictionary("ACER", "F5-571-55EJ", "500GB", "i5", "No", "15.6", "4GB", "specs", "9999"));
            m_database.Insert("product", CreateDictionary("ACER", "V3-371-77Z0", "240SSD", "i7", "No", "13.3", "4GB", "specs", "17499"));
            m_database.Insert("product", CreateDictionary("ACER", "E5-473-58HC", "500GB", "i5", "No", "14", "4GB", "prices", "9390"));
            m_database.Insert("product", CreateDictionary("ACER", "V5-591G-51J7", "1000GB", "i5", "GTX950M 2GB", "15.6", "4GB", "prices", "15299"));

		}
        //public Dictionary<string, string> CreateDictionary(string id, string brand, string name, string code, string cpu, string ram, string price)
		public Dictionary<string, string> CreateDictionary(string brand, string name, string hdd, string cpu, string vga, string size, string ram, string type, string price)
		{
			Dictionary<string, string> _dict = new Dictionary<string, string>();

			_dict.Add("name", name);
			_dict.Add("hdd", hdd);
			_dict.Add("brand", brand);
			_dict.Add("cpu", cpu);
			_dict.Add("vga", vga);
			_dict.Add("ram", ram);
            _dict.Add("size", size);
			_dict.Add("price", price);
            _dict.Add("type", type);
			return _dict;
		}
	}
}
