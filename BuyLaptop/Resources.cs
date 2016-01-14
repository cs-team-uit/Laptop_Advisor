using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BuyLaptop
{
	public static class Statics
	{
		public static string[] Brand =
		{
			"DELL",
			"HP",
			"LENOVO",
			"ACER",
			"ASUS"
		};

		public static string[] CPU =
		{
			"Celeron",
			"i3",
			"i5",
			"i7"
		};

		public static string[] VGA =
		{
			"No",
			"GT820M",
			"GT840M",
			"GT920M",
			"GT930M",
			"GT940M",
			"GT950M",
			"GTX 850M",
			"GTX 950M",
			"GTX 960M"
		};

		public static string[] ScreenSize =
		{
			"14",
			"15.6"
		};
	}

	public class Resources
	{
		SQLiteDatabase m_database;

		public Resources()
		{
			m_database = new SQLiteDatabase("laptop.s3db");

			//Insert();
		}

		private void Insert()
		{
			m_database.ClearTable("product");
			m_database.ClearTable("product");
			m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 3451", "N3451A", "Celeron", "No", "14", "2GB", "6299000"));
			m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 3552", "V5C007W", "Celeron", "No", "15.6", "2GB", "6250000"));
			m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 3458", "TXTGH1", "i3", "No", "14", "4GB", "8299000"));//DELL INSPIRON 3458 ( TXTGH1 ) Core™ i3 _ 4005U _ 4GB _ 500GB _ VGA INTEL_7151WD 9,299,000 VNĐ
			m_database.Insert("product", CreateDictionary("DELL", "INSPIRON 3543", "", "i3", "No", "15.6", "4GB", "8990000"));//DELL INSPIRON 3543 Intel® Broadwell Core™ i3 _ 5005U _ 4GB _ 500GB _ 15.6" HD _ Win8.1 _ USA
			m_database.Insert("product", CreateDictionary("HP", "ac024TU", "M7R77PA", "i3", "No", "14", "4GB", "9499000"));//HP 14 ac024TU (M7R77PA) Intel® Broadwell Core™ i3 _ 5010U _ 4GB _ 500GB _ VGA INTEL _ While
			m_database.Insert("product", CreateDictionary("HP", "ac009TU", "M4Y63PA", "i3", "No", "14", "4GB", "9699000"));//HP 15 ac009TU(M4Y63PA) Intel® Broadwell Core™ i3 _ 5010U _ 4GB _ 1TB _ VGA INTEL _ 9152TF
			m_database.Insert("product", CreateDictionary("LENOVO", "IdeaPad 100", "80MH008GVN", "Celeron", "No", "14", "2GB", "5799000"));//Lenovo IdeaPad 100 14IBY (80MH008GVN) Intel® Celeron® N2840 _ 2GB _ 500GB _ Intel _ Win 10 _12152FT
			m_database.Insert("product", CreateDictionary("LENOVO", "IdeaPad G4070", "59423768", "i3", "No", "14", "2GB", "8350000"));//Lenovo IdeaPad G4070 (59423768) Core i3 4030U - 2GB - 500GB - 14" HD LED
			m_database.Insert("product", CreateDictionary("LENOVO", "G5070", "59442751", "i3", "No", "15.6", "2GB", "8299000"));//LENOVO G5070 (59442751) Intel® Haswell Core™ i3 _ 4005U _ 2GB _ 500GB _ VGA INTEL _ WIN 8.1 BING
			m_database.Insert("product", CreateDictionary("ACER", " ASPIRE Z1401-C283", "NX.MT1SV.002", "Celeron", "No", "14", "4GB", "5399000"));//ACER ASPIRE Z1401-C283 ( NX.MT1SV.002 ) Intel® Celeron® Processor N2840 _ 4GB _ 500GB _ INTEL 5,990,000 VNĐ5,399,000 VNĐ
			m_database.Insert("product", CreateDictionary("ACER", "Aspire Z1402 34VY", "NX.G80SV.005", "i3", "No", "14", "2GB", "7990000"));//Acer Aspire Z1402 34VY _NX.G80SV.005 (70064770) Core™ i3 _ 5005U _ 2GB _ 500GB _ Intel _ 11152FT
			m_database.Insert("product", CreateDictionary("ACER", "Aspire E5", "573-35YX", "i3", "No", "14", "4GB", "7890000"));//Acer Aspire E5-573-35YX(70059909) Core i3-4005U_4GB_500GB_15.6" HD
			m_database.Insert("product", CreateDictionary("ASUS", "E Serial", "WX0038D", "Celeron", "No", "14", "2GB", "5300000"));//Asus E402MA-WX0038D _ Intel N2840_2GB_500GB_14" HD LED_10153TF
			m_database.Insert("product", CreateDictionary("ASUS", "E502MA", "XX0004D", "Celeron", "No", "15.6", "2GB", "5399000"));//ASUS E502MA XX0004D Intel® Celeron® N2840 _ 2GB _ 500GB _ VGA INTEL _ 15.6 HD_9151WD
			m_database.Insert("product", CreateDictionary("ASUS", "K455LA", "WX071D", "i3", "No", "14", "2GB", "8399000"));//ASUS K455LA WX071D Intel® Haswell Core™ i3 _ 4030U _ 2GB _ 500GB _ VGA INTEL
			m_database.Insert("product", CreateDictionary("ASUS", "X554LA", "XX1077D", "i3", "No", "15.6", "4GB", "8399000"));//ASUS X554LA XX1077D Intel® Broadwell Core™ i3 _ 5010U _ 4GB _ 500GB _ VGA INTEL_5154SV
			m_database.Insert("product", CreateDictionary("DELL", "Vostro", "5480", "i3", "No", "14", "4GB", "10399000"));//DELL Vostro 5480 Intel® Haswell Core™ i3 _ 4005U _ 4GB _ 500GB _ VGA Intel _ Finger
			m_database.Insert("product", CreateDictionary("DELL", "Inspiron N3543", "N3543A", "i3", "No", "15.6", "4GB", "10100000"));//Dell Inspiron N3543 (N3543A) Core i3 _ 5005U _ 4GB _ 500GB _ VGA Intel™
			m_database.Insert("product", CreateDictionary("DELL", "Inspiron", "3558", "i3", "GT840M", "15.6", "4GB", "11299000"));//Dell Inspiron 3558 (C5I3103W) Core i3 _4005U _4GB _500GB _VGA GT820M 2GB _ Win 8.1_7153DP
			m_database.Insert("product", CreateDictionary("DELL", "Inspiron", "N3543", "i7", "GT840M", "15.6", "8GB", "17199000"));//Dell Inspiron N3543 (696TP2) Core i7 _ 5500U _ 8GB _ 1TB _ VGA NVIDIA GT840M 2GB_6154SV
			m_database.Insert("product", CreateDictionary("DELL", "Vostro", "", "i3", "GT840M", "14", "4GB", "11499000"));
			m_database.Insert("product", CreateDictionary("DELL", "Inspiron", "", "i5", "GT920M", "14", "4GB", "12599000"));
			m_database.Insert("product", CreateDictionary("DELL", "Vostro", "", "i5", "GT920M", "15.6", "4GB", "12599000"));
			m_database.Insert("product", CreateDictionary("DELL", "Inspiron", "", "i5", "GT930M", "14", "4GB", "13299000"));
			m_database.Insert("product", CreateDictionary("DELL", "Vostro", "", "i5", "GT930M", "15.6", "4GB", "13350000"));

			m_database.Insert("product", CreateDictionary("HP", "Pavillon", "5480", "i3", "No", "14", "4GB", "10399000"));//DELL Vostro 5480 Intel® Haswell Core™ i3 _ 4005U _ 4GB _ 500GB _ VGA Intel _ Finger
			m_database.Insert("product", CreateDictionary("HP", "Pavillon", "N3543A", "i3", "No", "15.6", "4GB", "10100000"));//Dell Inspiron N3543 (N3543A) Core i3 _ 5005U _ 4GB _ 500GB _ VGA Intel™
			m_database.Insert("product", CreateDictionary("HP", "Probook", "3558", "i3", "GT840M", "15.6", "4GB", "11299000"));//Dell Inspiron 3558 (C5I3103W) Core i3 _4005U _4GB _500GB _VGA GT820M 2GB _ Win 8.1_7153DP
			m_database.Insert("product", CreateDictionary("HP", "Probook", "N3543", "i7", "GT840M", "15.6", "8GB", "17199000"));//Dell Inspiron N3543 (696TP2) Core i7 _ 5500U _ 8GB _ 1TB _ VGA NVIDIA GT840M 2GB_6154SV
			m_database.Insert("product", CreateDictionary("HP", "Pavillon", "", "i3", "GT840M", "14", "4GB", "11499000"));
			m_database.Insert("product", CreateDictionary("HP", "Probool", "", "i5", "GT920M", "14", "4GB", "12599000"));
			m_database.Insert("product", CreateDictionary("HP", "Probook", "", "i5", "GT920M", "15.6", "4GB", "12599000"));
			m_database.Insert("product", CreateDictionary("HP", "Pavillon", "", "i5", "GT930M", "14", "4GB", "13299000"));
			m_database.Insert("product", CreateDictionary("HP", "Pavillon", "", "i5", "GT930M", "15.6", "4GB", "13350000"));

			m_database.Insert("product", CreateDictionary("LENOVO", "Z Serial", "5070", "i3", "No", "14", "4GB", "10399000"));//DELL Vostro 5480 Intel® Haswell Core™ i3 _ 4005U _ 4GB _ 500GB _ VGA Intel _ Finger
			m_database.Insert("product", CreateDictionary("LENOVO", "Z Serial", "4070", "i3", "No", "15.6", "4GB", "10100000"));//Dell Inspiron N3543 (N3543A) Core i3 _ 5005U _ 4GB _ 500GB _ VGA Intel™
			m_database.Insert("product", CreateDictionary("LENOVO", "Z Serial", "4170", "i3", "GT840M", "15.6", "4GB", "11299000"));//Dell Inspiron 3558 (C5I3103W) Core i3 _4005U _4GB _500GB _VGA GT820M 2GB _ Win 8.1_7153DP
			m_database.Insert("product", CreateDictionary("LENOVO", "Z Serial", "4070", "i7", "GT840M", "15.6", "8GB", "17199000"));//Dell Inspiron N3543 (696TP2) Core i7 _ 5500U _ 8GB _ 1TB _ VGA NVIDIA GT840M 2GB_6154SV
			m_database.Insert("product", CreateDictionary("LENOVO", "Z Serial", "5170", "i3", "GT840M", "14", "4GB", "11499000"));
			m_database.Insert("product", CreateDictionary("LENOVO", "Z Serial", "5171", "i5", "GT920M", "14", "4GB", "12599000"));
			m_database.Insert("product", CreateDictionary("LENOVO", "Z Serial", "5050", "i5", "GT920M", "15.6", "4GB", "12599000"));
			m_database.Insert("product", CreateDictionary("LENOVO", "Z Serial", "5070", "i5", "GT930M", "14", "4GB", "13299000"));
			m_database.Insert("product", CreateDictionary("LENOVO", "Z Serial", "4070", "i5", "GT930M", "15.6", "4GB", "13350000")); 

			m_database.Insert("product", CreateDictionary("ACER", "E Serial", "5070", "i3", "No", "14", "4GB", "10399000"));//DELL Vostro 5480 Intel® Haswell Core™ i3 _ 4005U _ 4GB _ 500GB _ VGA Intel _ Finger
			m_database.Insert("product", CreateDictionary("ACER", "E Serial", "4070", "i3", "No", "15.6", "4GB", "10100000"));//Dell Inspiron N3543 (N3543A) Core i3 _ 5005U _ 4GB _ 500GB _ VGA Intel™
			m_database.Insert("product", CreateDictionary("ACER", "S Serial", "4170", "i3", "GT840M", "15.6", "4GB", "11299000"));//Dell Inspiron 3558 (C5I3103W) Core i3 _4005U _4GB _500GB _VGA GT820M 2GB _ Win 8.1_7153DP
			m_database.Insert("product", CreateDictionary("ACER", "S Serial", "4070", "i7", "GT840M", "15.6", "8GB", "17199000"));//Dell Inspiron N3543 (696TP2) Core i7 _ 5500U _ 8GB _ 1TB _ VGA NVIDIA GT840M 2GB_6154SV
			m_database.Insert("product", CreateDictionary("ACER", "E Serial", "5170", "i3", "GT840M", "14", "4GB", "11499000"));
			m_database.Insert("product", CreateDictionary("ACER", "S Serial", "5171", "i5", "GT920M", "14", "4GB", "12599000"));
			m_database.Insert("product", CreateDictionary("ACER", "E Serial", "5050", "i5", "GT920M", "15.6", "4GB", "12599000"));
			m_database.Insert("product", CreateDictionary("ACER", "E Serial", "5070", "i5", "GT930M", "14", "4GB", "13299000"));
			m_database.Insert("product", CreateDictionary("ACER", "Z Serial", "4070", "i5", "GT930M", "15.6", "4GB", "13350000"));
		}

		public Dictionary<string, string> CreateDictionary(string brand, string name, string code, string cpu, string vga, string size, string ram, string price)
		{
			Dictionary<string, string> _dict = new Dictionary<string, string>();

			_dict.Add("name", name);
			_dict.Add("code", code);
			_dict.Add("brand", brand);
			_dict.Add("cpu", cpu);
			_dict.Add("vga", vga);
			_dict.Add("ram", ram);
			_dict.Add("size", size);
			_dict.Add("price", price);

			return _dict;
		}
	}
}
