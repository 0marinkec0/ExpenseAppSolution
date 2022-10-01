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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Expense_Button = new System.Windows.Forms.Button();
            this.Income_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Income_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Expense_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 101);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 62);
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
            this.panel4.Size = new System.Drawing.Size(358, 59);
            this.panel4.TabIndex = 3;
            // 
            // Expense_Button
            // 
            this.Expense_Button.BackColor = System.Drawing.Color.IndianRed;
            this.Expense_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expense_Button.ForeColor = System.Drawing.Color.White;
            this.Expense_Button.Location = new System.Drawing.Point(255, 5);
            this.Expense_Button.Name = "Expense_Button";
            this.Expense_Button.Size = new System.Drawing.Size(100, 45);
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
            this.Income_Button.Location = new System.Drawing.Point(149, 5);
            this.Income_Button.Name = "Income_Button";
            this.Income_Button.Size = new System.Drawing.Size(100, 45);
            this.Income_Button.TabIndex = 1;
            this.Income_Button.Text = "+ Income";
            this.Income_Button.UseVisualStyleBackColor = false;
            this.Income_Button.Click += new System.EventHandler(this.Income_Button_Click);
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
            this.panel2.Controls.Add(this.Income_Label);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 59);
            this.panel2.TabIndex = 0;
            // 
            // Income_Label
            // 
            this.Income_Label.AutoSize = true;
            this.Income_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Income_Label.Location = new System.Drawing.Point(132, 27);
            this.Income_Label.Name = "Income_Label";
            this.Income_Label.Size = new System.Drawing.Size(55, 23);
            this.Income_Label.TabIndex = 1;
            this.Income_Label.Text = "$0.00";
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
            this.panel3.Controls.Add(this.Expense_Label);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(246, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 59);
            this.panel3.TabIndex = 2;
            // 
            // Expense_Label
            // 
            this.Expense_Label.AutoSize = true;
            this.Expense_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Expense_Label.Location = new System.Drawing.Point(132, 27);
            this.Expense_Label.Name = "Expense_Label";
            this.Expense_Label.Size = new System.Drawing.Size(55, 23);
            this.Expense_Label.TabIndex = 1;
            this.Expense_Label.Text = "$0.00";
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
            // dataGridTable
            // 
            this.dataGridTable.AllowUserToAddRows = false;
            this.dataGridTable.AllowUserToDeleteRows = false;
            this.dataGridTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTable.ColumnHeadersHeight = 50;
            this.dataGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridTable.EnableHeadersVisualStyles = false;
            this.dataGridTable.Location = new System.Drawing.Point(220, 101);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridTable.RowTemplate.Height = 25;
            this.dataGridTable.Size = new System.Drawing.Size(624, 406);
            this.dataGridTable.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Format = "C2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 200F;
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.dataGridTable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(847, 510);
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
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
        private Label Income_Label;
        private Label label1;
        private Panel panel3;
        private Label Expense_Label;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        public DataGridView dataGridTable;
    }
}
