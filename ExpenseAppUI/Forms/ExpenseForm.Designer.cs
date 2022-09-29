namespace ExpenseAppUI.Forms
{
    partial class ExpenseForm
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
            this.Amount_TextBox = new System.Windows.Forms.TextBox();
            this.Category_TextBox = new System.Windows.Forms.TextBox();
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker_ExpenseForm = new System.Windows.Forms.DateTimePicker();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Amount_TextBox
            // 
            this.Amount_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount_TextBox.Location = new System.Drawing.Point(31, 90);
            this.Amount_TextBox.Name = "Amount_TextBox";
            this.Amount_TextBox.PlaceholderText = "Amount";
            this.Amount_TextBox.Size = new System.Drawing.Size(195, 23);
            this.Amount_TextBox.TabIndex = 0;
            // 
            // Category_TextBox
            // 
            this.Category_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Category_TextBox.Location = new System.Drawing.Point(31, 158);
            this.Category_TextBox.Name = "Category_TextBox";
            this.Category_TextBox.PlaceholderText = "Category";
            this.Category_TextBox.Size = new System.Drawing.Size(195, 23);
            this.Category_TextBox.TabIndex = 1;
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description_TextBox.Location = new System.Drawing.Point(267, 90);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.PlaceholderText = "Description";
            this.Description_TextBox.Size = new System.Drawing.Size(240, 91);
            this.Description_TextBox.TabIndex = 2;
            // 
            // DateTimePicker_ExpenseForm
            // 
            this.DateTimePicker_ExpenseForm.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker_ExpenseForm.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateTimePicker_ExpenseForm.Location = new System.Drawing.Point(267, 30);
            this.DateTimePicker_ExpenseForm.Name = "DateTimePicker_ExpenseForm";
            this.DateTimePicker_ExpenseForm.Size = new System.Drawing.Size(195, 23);
            this.DateTimePicker_ExpenseForm.TabIndex = 3;
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.Color.SlateBlue;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_Button.ForeColor = System.Drawing.Color.White;
            this.Save_Button.Location = new System.Drawing.Point(403, 227);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(104, 36);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "+ Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close_Button.ForeColor = System.Drawing.Color.Red;
            this.Close_Button.Location = new System.Drawing.Point(309, 227);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(88, 36);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Text = "X Close";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(546, 288);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.DateTimePicker_ExpenseForm);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.Category_TextBox);
            this.Controls.Add(this.Amount_TextBox);
            this.Name = "ExpenseForm";
            this.Text = "ExpenseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Amount_TextBox;
        private TextBox Category_TextBox;
        private TextBox Description_TextBox;
        private DateTimePicker DateTimePicker_ExpenseForm;
        private Button Save_Button;
        private Button Close_Button;
    }
}