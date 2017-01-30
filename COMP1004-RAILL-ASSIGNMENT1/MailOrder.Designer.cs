/// MailOrder.Designer.cs page
///Author: Tiffany Raill, Created on January 16, 2017
/// This is an app that allows a user to calculate the Sales Bonus per employee
/// based on 2% of their sales and their hours worked.
namespace COMP1004_RAILL_ASSIGNMENT1
{
    partial class SalesBonus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonus));
            this.languageBox = new System.Windows.Forms.GroupBox();
            this.espagnolRadioButton = new System.Windows.Forms.RadioButton();
            this.francaisRadioButton = new System.Windows.Forms.RadioButton();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.totalSalesTextBox = new System.Windows.Forms.TextBox();
            this.salesBonusTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.salesBonusLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.languageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // languageBox
            // 
            this.languageBox.Controls.Add(this.espagnolRadioButton);
            this.languageBox.Controls.Add(this.francaisRadioButton);
            this.languageBox.Controls.Add(this.englishRadioButton);
            this.languageBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.languageBox.Location = new System.Drawing.Point(325, 12);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(200, 136);
            this.languageBox.TabIndex = 0;
            this.languageBox.TabStop = false;
            this.languageBox.Text = "Language";
            // 
            // espagnolRadioButton
            // 
            this.espagnolRadioButton.AutoSize = true;
            this.espagnolRadioButton.Location = new System.Drawing.Point(18, 97);
            this.espagnolRadioButton.Name = "espagnolRadioButton";
            this.espagnolRadioButton.Size = new System.Drawing.Size(132, 33);
            this.espagnolRadioButton.TabIndex = 2;
            this.espagnolRadioButton.TabStop = true;
            this.espagnolRadioButton.Text = "Espagnol\r\n";
            this.espagnolRadioButton.UseVisualStyleBackColor = true;
            this.espagnolRadioButton.CheckedChanged += new System.EventHandler(this.espagnolRadioButton_CheckedChanged);
            // 
            // francaisRadioButton
            // 
            this.francaisRadioButton.AutoSize = true;
            this.francaisRadioButton.Location = new System.Drawing.Point(18, 66);
            this.francaisRadioButton.Name = "francaisRadioButton";
            this.francaisRadioButton.Size = new System.Drawing.Size(128, 33);
            this.francaisRadioButton.TabIndex = 1;
            this.francaisRadioButton.TabStop = true;
            this.francaisRadioButton.Text = "Français";
            this.francaisRadioButton.UseVisualStyleBackColor = true;
            this.francaisRadioButton.CheckedChanged += new System.EventHandler(this.francaisRadioButton_CheckedChanged);
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Checked = true;
            this.englishRadioButton.Location = new System.Drawing.Point(18, 36);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(113, 33);
            this.englishRadioButton.TabIndex = 0;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            this.englishRadioButton.CheckedChanged += new System.EventHandler(this.englishRadioButton_CheckedChanged);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.AcceptsTab = true;
            this.EmployeeNameTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(299, 199);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(226, 35);
            this.EmployeeNameTextBox.TabIndex = 1;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.AcceptsTab = true;
            this.employeeIDTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTextBox.Location = new System.Drawing.Point(299, 245);
            this.employeeIDTextBox.MaxLength = 12;
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(226, 35);
            this.employeeIDTextBox.TabIndex = 2;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(299, 289);
            this.hoursWorkedTextBox.MaxLength = 6;
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(226, 35);
            this.hoursWorkedTextBox.TabIndex = 3;
            this.hoursWorkedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalSalesTextBox
            // 
            this.totalSalesTextBox.AcceptsTab = true;
            this.totalSalesTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesTextBox.Location = new System.Drawing.Point(299, 337);
            this.totalSalesTextBox.MaxLength = 10;
            this.totalSalesTextBox.Name = "totalSalesTextBox";
            this.totalSalesTextBox.Size = new System.Drawing.Size(226, 35);
            this.totalSalesTextBox.TabIndex = 4;
            this.totalSalesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // salesBonusTextBox
            // 
            this.salesBonusTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.salesBonusTextBox.Enabled = false;
            this.salesBonusTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBonusTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.salesBonusTextBox.Location = new System.Drawing.Point(299, 384);
            this.salesBonusTextBox.Name = "salesBonusTextBox";
            this.salesBonusTextBox.ReadOnly = true;
            this.salesBonusTextBox.ShortcutsEnabled = false;
            this.salesBonusTextBox.Size = new System.Drawing.Size(226, 35);
            this.salesBonusTextBox.TabIndex = 5;
            this.salesBonusTextBox.TabStop = false;
            this.salesBonusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.salesBonusTextBox.WordWrap = false;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeNameLabel.Location = new System.Drawing.Point(35, 205);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(208, 29);
            this.employeeNameLabel.TabIndex = 6;
            this.employeeNameLabel.Text = "Employee\'s Name:";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeIDLabel.Location = new System.Drawing.Point(35, 250);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(155, 29);
            this.employeeIDLabel.TabIndex = 7;
            this.employeeIDLabel.Text = "Employee ID:";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(35, 294);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(170, 29);
            this.hoursWorkedLabel.TabIndex = 8;
            this.hoursWorkedLabel.Text = "Hours Worked:";
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalSalesLabel.Location = new System.Drawing.Point(35, 342);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(141, 29);
            this.totalSalesLabel.TabIndex = 9;
            this.totalSalesLabel.Text = "Total Sales:";
            // 
            // salesBonusLabel
            // 
            this.salesBonusLabel.AutoSize = true;
            this.salesBonusLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBonusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesBonusLabel.Location = new System.Drawing.Point(39, 390);
            this.salesBonusLabel.Name = "salesBonusLabel";
            this.salesBonusLabel.Size = new System.Drawing.Size(147, 29);
            this.salesBonusLabel.TabIndex = 10;
            this.salesBonusLabel.Text = "Sales Bonus:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(39, 467);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(136, 34);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(225, 467);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(136, 34);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(400, 467);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(125, 34);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Next";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // SalesBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(548, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.salesBonusLabel);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.salesBonusTextBox);
            this.Controls.Add(this.totalSalesTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.languageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesBonus";
            this.Text = "Sales Bonus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.languageBox.ResumeLayout(false);
            this.languageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox languageBox;
        private System.Windows.Forms.RadioButton francaisRadioButton;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox totalSalesTextBox;
        private System.Windows.Forms.TextBox salesBonusTextBox;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label salesBonusLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RadioButton espagnolRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

