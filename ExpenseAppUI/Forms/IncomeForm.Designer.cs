namespace ExpenseAppUI.Forms
{
    partial class IncomeForm
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
            this.IncomeSave_Button = new System.Windows.Forms.Button();
            this.IncomeClose_Button = new System.Windows.Forms.Button();
            this.DateTimePicker_IncomeForm = new System.Windows.Forms.DateTimePicker();
            this.IncomeDescription_TextBox = new System.Windows.Forms.TextBox();
            this.IncomeCategory_TextBox = new System.Windows.Forms.TextBox();
            this.IncomeAmount_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IncomeSave_Button
            // 
            this.IncomeSave_Button.BackColor = System.Drawing.Color.SlateBlue;
            this.IncomeSave_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeSave_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomeSave_Button.ForeColor = System.Drawing.Color.White;
            this.IncomeSave_Button.Location = new System.Drawing.Point(407, 230);
            this.IncomeSave_Button.Name = "IncomeSave_Button";
            this.IncomeSave_Button.Size = new System.Drawing.Size(104, 36);
            this.IncomeSave_Button.TabIndex = 11;
            this.IncomeSave_Button.Text = "+ Save";
            this.IncomeSave_Button.UseVisualStyleBackColor = false;
            this.IncomeSave_Button.Click += new System.EventHandler(this.IncomeSave_Button_Click);
            // 
            // IncomeClose_Button
            // 
            this.IncomeClose_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeClose_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomeClose_Button.ForeColor = System.Drawing.Color.Red;
            this.IncomeClose_Button.Location = new System.Drawing.Point(313, 230);
            this.IncomeClose_Button.Name = "IncomeClose_Button";
            this.IncomeClose_Button.Size = new System.Drawing.Size(88, 36);
            this.IncomeClose_Button.TabIndex = 10;
            this.IncomeClose_Button.Text = "X Close";
            this.IncomeClose_Button.UseVisualStyleBackColor = true;
            this.IncomeClose_Button.Click += new System.EventHandler(this.IncomeClose_Button_Click);
            // 
            // DateTimePicker_IncomeForm
            // 
            this.DateTimePicker_IncomeForm.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker_IncomeForm.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateTimePicker_IncomeForm.Location = new System.Drawing.Point(271, 33);
            this.DateTimePicker_IncomeForm.Name = "DateTimePicker_IncomeForm";
            this.DateTimePicker_IncomeForm.Size = new System.Drawing.Size(195, 23);
            this.DateTimePicker_IncomeForm.TabIndex = 9;
            // 
            // IncomeDescription_TextBox
            // 
            this.IncomeDescription_TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomeDescription_TextBox.Location = new System.Drawing.Point(271, 93);
            this.IncomeDescription_TextBox.Multiline = true;
            this.IncomeDescription_TextBox.Name = "IncomeDescription_TextBox";
            this.IncomeDescription_TextBox.PlaceholderText = "Description";
            this.IncomeDescription_TextBox.Size = new System.Drawing.Size(240, 91);
            this.IncomeDescription_TextBox.TabIndex = 8;
            // 
            // IncomeCategory_TextBox
            // 
            this.IncomeCategory_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IncomeCategory_TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomeCategory_TextBox.Location = new System.Drawing.Point(35, 159);
            this.IncomeCategory_TextBox.Name = "IncomeCategory_TextBox";
            this.IncomeCategory_TextBox.PlaceholderText = "Category";
            this.IncomeCategory_TextBox.Size = new System.Drawing.Size(195, 25);
            this.IncomeCategory_TextBox.TabIndex = 7;
            // 
            // IncomeAmount_TextBox
            // 
            this.IncomeAmount_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IncomeAmount_TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomeAmount_TextBox.Location = new System.Drawing.Point(35, 93);
            this.IncomeAmount_TextBox.Name = "IncomeAmount_TextBox";
            this.IncomeAmount_TextBox.PlaceholderText = "Amount";
            this.IncomeAmount_TextBox.Size = new System.Drawing.Size(195, 25);
            this.IncomeAmount_TextBox.TabIndex = 6;
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 286);
            this.Controls.Add(this.IncomeSave_Button);
            this.Controls.Add(this.IncomeClose_Button);
            this.Controls.Add(this.DateTimePicker_IncomeForm);
            this.Controls.Add(this.IncomeDescription_TextBox);
            this.Controls.Add(this.IncomeCategory_TextBox);
            this.Controls.Add(this.IncomeAmount_TextBox);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button IncomeSave_Button;
        private Button IncomeClose_Button;
        private DateTimePicker DateTimePicker_IncomeForm;
        private TextBox IncomeDescription_TextBox;
        private TextBox IncomeCategory_TextBox;
        private TextBox IncomeAmount_TextBox;
    }
}