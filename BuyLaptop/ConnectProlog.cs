using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Connect_Prolog
{
    class ConnectProlog
    {
        //Load prolog file from hard disk
        public void Load_file(string s)
        {
            s = s.Replace("\\", "//");
            s = "consult('" + s + "')";
            string query = s.Replace("\\", "//");
            //string[] p = { "-q", "-f", query };
            //PlEngine.Initialize(p);
            try
            {
                PlQuery q = new PlQuery(query);
                Assert.IsTrue(q.NextSolution());
            }
            catch (SbsSW.SwiPlCs.Exceptions.PlException e)
            {
				System.Windows.Forms.MessageBox.Show(e.ToString(), "Error");
			}
        }

        // Prosessing a query
        public string Query(string s)
        {
            s.Trim();
            Regex r = new Regex(@"[A-Z_][a-zA-Z_]*");
            MatchCollection matches = r.Matches(s);
            string result = "";
            try
            {
                PlQuery q = new PlQuery(s);
                bool HasSolution = false;
                foreach (PlQueryVariables v in q.SolutionVariables)
                {
                    HasSolution = true;
                    foreach (Match match in matches)
                    {
                        result += v[match.ToString()].ToString() + " ; ";
                    }
                }
                if (matches.Count == 0)
                    return HasSolution ? "true" : "false";
                return result;
            }
            catch (SbsSW.SwiPlCs.Exceptions.PlException ex)
            {
                return "Error query: " + ex.Message;
            }
        }
    }
}
