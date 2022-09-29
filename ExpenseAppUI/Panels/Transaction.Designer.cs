namespace ExpenseAppUI
{
    partial class Transaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Expense_Button = new System.Windows.Forms.Button();
            this.Income_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 126);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 62);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.Expense_Button);
            this.panel4.Controls.Add(this.Income_Button);
            this.panel4.Controls.Add(this.Delete_Button);
            this.panel4.Location = new System.Drawing.Point(480, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 59);
            this.panel4.TabIndex = 3;
            // 
            // Expense_Button
            // 
            this.Expense_Button.BackColor = System.Drawing.Color.IndianRed;
            this.Expense_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expense_Button.ForeColor = System.Drawing.Color.White;
            this.Expense_Button.Location = new System.Drawing.Point(219, 5);
            this.Expense_Button.Name = "Expense_Button";
            this.Expense_Button.Size = new System.Drawing.Size(88, 45);
            this.Expense_Button.TabIndex = 2;
            this.Expense_Button.Text = "- Expense";
            this.Expense_Button.UseVisualStyleBackColor = false;
            this.Expense_Button.Click += new System.EventHandler(this.Expense_Button_Click);
            // 
            // Income_Button
            // 
            this.Income_Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Income_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Income_Button.ForeColor = System.Drawing.Color.White;
            this.Income_Button.Location = new System.Drawing.Point(125, 5);
            this.Income_Button.Name = "Income_Button";
            this.Income_Button.Size = new System.Drawing.Size(88, 45);
            this.Income_Button.TabIndex = 1;
            this.Income_Button.Text = "+ Income";
            this.Income_Button.UseVisualStyleBackColor = false;
            // 
            // Delete_Button
            // 
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.ForeColor = System.Drawing.Color.Red;
            this.Delete_Button.Location = new System.Drawing.Point(31, 5);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(88, 45);
            this.Delete_Button.TabIndex = 0;
            this.Delete_Button.Text = "X Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 59);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(244, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 59);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(150, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Expense:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(549, 361);
            this.dataGridView1.TabIndex = 3;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(810, 490);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Panel panel1;
        private Panel panel4;
        private Button Expense_Button;
        private Button Income_Button;
        private Button Delete_Button;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
