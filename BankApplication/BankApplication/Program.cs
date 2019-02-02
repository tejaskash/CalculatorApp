using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public static class Users
    {
        public static int index = 0;
        public static string[] names = {"cust1","cust2"};
        public static string[] pass = {"pass1","pass2"};
        public static double[] balance = {10000,1000};
    } 

}
