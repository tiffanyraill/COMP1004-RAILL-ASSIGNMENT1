/// MailOrderFunctionality.cs page
///@Author: Tiffany Raill, Created on January 16, 2017
/// This is an app that allows a user to calculate the Sales Bonus per employee
/// based on 2% of their sales and their hours worked.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_RAILL_ASSIGNMENT1
{
    public partial class SalesBonus : Form
    {
        public SalesBonus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            employeeIDTextBox.Text = "";
            hoursWorkedTextBox.Text = "";
            salesBonusTextBox.Text = "";


        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ///Divide the Total Hours Worked by 160. This will determine the Percentage of hours worked during the bonus period.
            ///Multiply Total Monthly Sales by 0.02 – This will calculate 2% of Sales which is the Total Bonus Amount. 
            ///Multiply the Percentage of Hours Worked by the Total Bonus Amount. 
            /// This will determine the value you need to display in the Sales Bonus Text Field.

            decimal hours = Convert.ToDecimal(hoursWorkedTextBox.Text);
            decimal maxHours = 160;
            decimal percentHours = hours / maxHours;

            decimal sales = Convert.ToDecimal(totalSalesTextBox.Text);
            decimal percentOfSales = .02m;
            decimal totalSales = sales * percentOfSales;
           /// totalSalesTextBox.Text = totalSales.ToString("c");

            decimal salesBonus = Math.Round(percentHours * totalSales, 2);


            salesBonusTextBox.Text = Convert.ToString(salesBonus);
            ///add some currency formatting
            salesBonusTextBox.Text = salesBonus.ToString("c");
          
        }
    }
}
