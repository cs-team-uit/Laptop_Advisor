﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BuyLaptop
{
	public class Resources
	{
		SQLiteDatabase m_database;

		public Resources()
		{
			m_database = new SQLiteDatabase("laptop_info.s3db");

			//Insert();
		}

		private void Insert()
		{
			m_database.Insert("product", CreateDictionary("Máy xách tay Laptop HP Stream 11-d033TU (N4F93PA) (Tím)",
				"N4F93PA", "HP", "Celeron", "", "2GB", "4.900.000 VNĐ"));
		}

		public Dictionary<string, string> CreateDictionary(string name, string code, string brand, string cpu, string vga, string ram, string price)
		{
			Dictionary<string, string> _dict = new Dictionary<string, string>();

			_dict.Add("name", name);
			_dict.Add("code", code);
			_dict.Add("brand", brand);
			_dict.Add("cpu", cpu);
			_dict.Add("vga", vga);
			_dict.Add("ram", ram);
			_dict.Add("price", price);

			return _dict;
		}
	}
}
