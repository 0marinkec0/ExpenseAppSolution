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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Amount_TextBox
            // 
            this.Amount_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount_TextBox.Location = new System.Drawing.Point(30, 129);
            this.Amount_TextBox.Name = "Amount_TextBox";
            this.Amount_TextBox.PlaceholderText = "Amount";
            this.Amount_TextBox.Size = new System.Drawing.Size(195, 23);
            this.Amount_TextBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(30, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Amount";
            this.textBox1.Size = new System.Drawing.Size(195, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description_TextBox.Location = new System.Drawing.Point(266, 129);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.PlaceholderText = "Description";
            this.Description_TextBox.Size = new System.Drawing.Size(240, 66);
            this.Description_TextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(546, 288);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Amount_TextBox);
            this.Name = "ExpenseForm";
            this.Text = "ExpenseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Amount_TextBox;
        private TextBox textBox1;
        private TextBox Description_TextBox;
        private ComboBox comboBox1;
    }
}