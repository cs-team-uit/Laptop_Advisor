using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyLaptop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			if(System.IO.Directory.Exists("C:\\Program Files (x86)\\swipl\\"))
			{
				Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\swipl");
			}
			else if(System.IO.Directory.Exists("C:\\Program Files\\swipl\\"))
			{
				Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files\swipl");
			}
            else
            {
                MessageBox.Show("Prolog chưa được cài đăt hoặc vị trí sai, vui lòng cài đặt Prolog 6.6.5 vào vị trí mặc định trên ổ C.");
                return;
            }

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (!PlEngine.IsInitialized)
            {
                String[] empty_param = { "" };
                PlEngine.Initialize(empty_param);
                Application.Run(new frm_Main());
                PlEngine.PlCleanup();
            }
        }
    }
}
