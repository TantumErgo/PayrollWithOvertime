namespace Payroll_with_Overtime
{
    partial class Form1
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
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.grossPayNameLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(65, 37);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(79, 13);
            this.hoursWorkedLabel.TabIndex = 0;
            this.hoursWorkedLabel.Text = "Hours Worked:";
            // 
            // hourlyRateLabel
            // 
            this.hourlyRateLabel.AutoSize = true;
            this.hourlyRateLabel.Location = new System.Drawing.Point(65, 82);
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            this.hourlyRateLabel.Size = new System.Drawing.Size(87, 13);
            this.hourlyRateLabel.TabIndex = 1;
            this.hourlyRateLabel.Text = "Hourly Pay Rate:";
            // 
            // grossPayNameLabel
            // 
            this.grossPayNameLabel.AutoSize = true;
            this.grossPayNameLabel.Location = new System.Drawing.Point(65, 134);
            this.grossPayNameLabel.Name = "grossPayNameLabel";
            this.grossPayNameLabel.Size = new System.Drawing.Size(58, 13);
            this.grossPayNameLabel.TabIndex = 2;
            this.grossPayNameLabel.Text = "Gross Pay:";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Location = new System.Drawing.Point(160, 134);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(103, 22);
            this.grossPayLabel.TabIndex = 3;
            this.grossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(163, 37);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursWorkedTextBox.TabIndex = 4;
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(163, 79);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.hourlyPayRateTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(3, 190);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 41);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Gross Pay";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(98, 190);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(188, 190);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.grossPayNameLabel);
            this.Controls.Add(this.hourlyRateLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Name = "Form1";
            this.Text = "Payroll with Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label hourlyRateLabel;
        private System.Windows.Forms.Label grossPayNameLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

