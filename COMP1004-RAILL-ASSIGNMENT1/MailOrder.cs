/// MailOrderFunctionality.cs page
///@Author: Tiffany Raill, Created on January 16, 2017
/// This is an app that allows a user to calculate the Sales Bonus per employee
/// based on 2% of their sales and their hours worked.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        //Clears EmployeeName, EmployeeID, hoursWorked, and Sales Bonus Fields
        private void ClearButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            employeeIDTextBox.Text = "";
            hoursWorkedTextBox.Text = "";
            salesBonusTextBox.Text = "";
        }

        //Shows "Now Printing" Message Dialogue box
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing");
        }

        /// <summary>
        /// This section calculates the Sales Bonus per Employee.
        /// </summary>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ///Divide the Total Hours Worked by 160. This will determine the Percentage of hours worked during the bonus period.
            ///Multiply Total Monthly Sales by 0.02 – This will calculate 2% of Sales which is the Total Bonus Amount. 
            ///Multiply the Percentage of Hours Worked by the Total Bonus Amount. 
            /// This will determine the value you need to display in the Sales Bonus Text Field.
            
            try
            {
                decimal hours = Convert.ToDecimal(hoursWorkedTextBox.Text);
                decimal maxHours = 160;
                decimal percentHours = hours / maxHours;
                ///determine if the hours are within the range of 1-160
                if (hours > 160 || hours <= 0)
                {
                    MessageBox.Show("Please Enter 1-160 Hours");
                }

                decimal sales = Convert.ToDecimal(totalSalesTextBox.Text);
                decimal percentOfSales = .02m;
                decimal totalSales = sales * percentOfSales;
              
                decimal salesBonus = Math.Round(percentHours * totalSales, 2);
                salesBonusTextBox.Text = Convert.ToString(salesBonus);
                ///add some currency formatting
                salesBonusTextBox.Text = salesBonus.ToString("c");
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Invalid Data Entry");
            }

        }

        /// <summary>
        /// Language Radio Button Options
        /// Default language is English
        /// </summary>
        private void englishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
                //make this the default checked radio button
                englishRadioButton.AutoCheck = true;

                languageBox.Text = "Language";
                englishRadioButton.Text = "English";
                francaisRadioButton.Text = "French";
                espagnolRadioButton.Text = "Spanish";
                employeeNameLabel.Text = "Employee's Name:";
                employeeIDLabel.Text = "Employee ID:";
                hoursWorkedLabel.Text = "Hours Worked:";
                totalSalesLabel.Text = "Total Sales:";
                salesBonusLabel.Text = "Sales Bonus:";
                CalculateButton.Text = "Calculate";
                PrintButton.Text = "Print";
                ClearButton.Text = "Next";

        }

        /// <summary>
        ///Language Selected: French
        /// </summary>
        private void francaisRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            languageBox.Text = "Language";
            englishRadioButton.Text = "Anglais";
            francaisRadioButton.Text = "Français";
            espagnolRadioButton.Text = "Espagnol";
            employeeNameLabel.Text = "Nom de l'Employé:";
            employeeIDLabel.Text = "Nº Employé:";
            hoursWorkedLabel.Text = "Heures Travaillées:";
            totalSalesLabel.Text = "Total des ventes:";
            salesBonusLabel.Text = "Prime à la vente:";
            CalculateButton.Text = "Calculez";
            PrintButton.Text = "Imprimer";
            ClearButton.Text = "Suivant";

        }
        /// <summary>
        ///Language Selected: Spanish
        /// </summary>
        private void espagnolRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            languageBox.Text = "Idioma";
            englishRadioButton.Text = "Inglés";
            francaisRadioButton.Text = "Francés";
            espagnolRadioButton.Text = "Español";
            employeeNameLabel.Text = "Nombre del empleado:";
            employeeIDLabel.Text = "Nº del empleado:";
            hoursWorkedLabel.Text = "Horas trabajadas:";
            totalSalesLabel.Text = "Ventas totales:";
            salesBonusLabel.Text = "Prima de las ventas:";
            CalculateButton.Text = "Calcule";
            PrintButton.Text = "Impresión";
            ClearButton.Text = "Siguiente";

        }
    }
}

