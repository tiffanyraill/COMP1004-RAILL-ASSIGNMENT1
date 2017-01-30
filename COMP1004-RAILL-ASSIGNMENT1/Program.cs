/// MailOrderFunctionality.cs page
///Author: Tiffany Raill, Created on January 16, 2017
/// This is an app that allows a user to calculate the Sales Bonus per employee
/// based on 2% of their sales and their hours worked.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_RAILL_ASSIGNMENT1
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
            Application.Run(new SalesBonus());
        }
    }
}
