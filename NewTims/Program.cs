using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTims
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string x = Lib.Item("aaaa,bbb,cc,a",3);
            Application.Run(new Student_Form());
            //OleDbConnection myConnection = new OleDbConnection("Provider=MSOLEDBSQL;Server=localHost;Database=" + "TIMS" + ";Trusted_Connection=yes;");
         }
    }
}
