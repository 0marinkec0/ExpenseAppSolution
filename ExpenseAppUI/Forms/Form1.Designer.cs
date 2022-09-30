namespace ExpenseAppUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_Button = new System.Windows.Forms.Button();
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.AccountLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Login_Email_TextBox = new System.Windows.Forms.TextBox();
            this.Register_Panel = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.LinkLabel();
            this.Email = new System.Windows.Forms.Label();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Register_Button = new System.Windows.Forms.Button();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.Login_Panel.SuspendLayout();
            this.Register_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Login_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_Button.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.Location = new System.Drawing.Point(61, 363);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(256, 45);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login_Panel
            // 
            this.Login_Panel.Controls.Add(this.AccountLabel);
            this.Login_Panel.Controls.Add(this.label5);
            this.Login_Panel.Controls.Add(this.Password_Label);
            this.Login_Panel.Controls.Add(this.Login_Password_TextBox);
            this.Login_Panel.Controls.Add(this.Email_Label);
            this.Login_Panel.Controls.Add(this.Login_Button);
            this.Login_Panel.Controls.Add(this.Login_Email_TextBox);
            this.Login_Panel.Location = new System.Drawing.Point(41, 12);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(416, 449);
            this.Login_Panel.TabIndex = 4;
            // 
            // AccountLabel
            // 
            this.AccountLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountLabel.LinkColor = System.Drawing.Color.White;
            this.AccountLabel.Location = new System.Drawing.Point(79, 418);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(222, 21);
            this.AccountLabel.TabIndex = 6;
            this.AccountLabel.TabStop = true;
            this.AccountLabel.Text = "Don\'t have account? Click here";
            this.AccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AccountLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(128, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Please Login";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_Label.ForeColor = System.Drawing.Color.White;
            this.Password_Label.Location = new System.Drawing.Point(32, 203);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(77, 21);
            this.Password_Label.TabIndex = 4;
            this.Password_Label.Text = "Password";
            // 
            // Login_Password_TextBox
            // 
            this.Login_Password_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Login_Password_TextBox.ForeColor = System.Drawing.Color.White;
            this.Login_Password_TextBox.Location = new System.Drawing.Point(32, 227);
            this.Login_Password_TextBox.Multiline = true;
            this.Login_Password_TextBox.Name = "Login_Password_TextBox";
            this.Login_Password_TextBox.Size = new System.Drawing.Size(355, 35);
            this.Login_Password_TextBox.TabIndex = 3;
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email_Label.ForeColor = System.Drawing.Color.White;
            this.Email_Label.Location = new System.Drawing.Point(32, 95);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(48, 21);
            this.Email_Label.TabIndex = 2;
            this.Email_Label.Text = "Email";
            // 
            // Login_Email_TextBox
            // 
            this.Login_Email_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Login_Email_TextBox.ForeColor = System.Drawing.Color.White;
            this.Login_Email_TextBox.Location = new System.Drawing.Point(32, 120);
            this.Login_Email_TextBox.Multiline = true;
            this.Login_Email_TextBox.Name = "Login_Email_TextBox";
            this.Login_Email_TextBox.Size = new System.Drawing.Size(355, 35);
            this.Login_Email_TextBox.TabIndex = 0;
            // 
            // Register_Panel
            // 
            this.Register_Panel.Controls.Add(this.LoginLabel);
            this.Register_Panel.Controls.Add(this.Email);
            this.Register_Panel.Controls.Add(this.Email_TextBox);
            this.Register_Panel.Controls.Add(this.label8);
            this.Register_Panel.Controls.Add(this.Password_TextBox);
            this.Register_Panel.Controls.Add(this.label7);
            this.Register_Panel.Controls.Add(this.LastName_TextBox);
            this.Register_Panel.Controls.Add(this.label6);
            this.Register_Panel.Controls.Add(this.label2);
            this.Register_Panel.Controls.Add(this.ConfirmPassword_TextBox);
            this.Register_Panel.Controls.Add(this.label3);
            this.Register_Panel.Controls.Add(this.Register_Button);
            this.Register_Panel.Controls.Add(this.FirstName_TextBox);
            this.Register_Panel.Location = new System.Drawing.Point(504, 12);
            this.Register_Panel.Name = "Register_Panel";
            this.Register_Panel.Size = new System.Drawing.Size(400, 449);
            this.Register_Panel.TabIndex = 5;
            // 
            // LoginLabel
            // 
            this.LoginLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.LinkColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(98, 418);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(170, 21);
            this.LoginLabel.TabIndex = 7;
            this.LoginLabel.TabStop = true;
            this.LoginLabel.Text = "Already have a account";
            this.LoginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLabel_LinkClicked);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(32, 132);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 21);
            this.Email.TabIndex = 12;
            this.Email.Text = "Email";
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Email_TextBox.ForeColor = System.Drawing.Color.White;
            this.Email_TextBox.Location = new System.Drawing.Point(32, 156);
            this.Email_TextBox.Multiline = true;
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(340, 35);
            this.Email_TextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Password";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Password_TextBox.ForeColor = System.Drawing.Color.White;
            this.Password_TextBox.Location = new System.Drawing.Point(32, 223);
            this.Password_TextBox.Multiline = true;
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(340, 35);
            this.Password_TextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(217, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Last Name";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LastName_TextBox.ForeColor = System.Drawing.Color.White;
            this.LastName_TextBox.Location = new System.Drawing.Point(217, 84);
            this.LastName_TextBox.Multiline = true;
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(160, 35);
            this.LastName_TextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(133, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Register for free";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password";
            // 
            // ConfirmPassword_TextBox
            // 
            this.ConfirmPassword_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ConfirmPassword_TextBox.ForeColor = System.Drawing.Color.White;
            this.ConfirmPassword_TextBox.Location = new System.Drawing.Point(32, 295);
            this.ConfirmPassword_TextBox.Multiline = true;
            this.ConfirmPassword_TextBox.Name = "ConfirmPassword_TextBox";
            this.ConfirmPassword_TextBox.Size = new System.Drawing.Size(340, 35);
            this.ConfirmPassword_TextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // Register_Button
            // 
            this.Register_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Register_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Register_Button.FlatAppearance.BorderSize = 0;
            this.Register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Register_Button.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register_Button.ForeColor = System.Drawing.Color.White;
            this.Register_Button.Location = new System.Drawing.Point(64, 363);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(256, 45);
            this.Register_Button.TabIndex = 2;
            this.Register_Button.Text = "Register";
            this.Register_Button.UseVisualStyleBackColor = false;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.FirstName_TextBox.ForeColor = System.Drawing.Color.White;
            this.FirstName_TextBox.Location = new System.Drawing.Point(32, 84);
            this.FirstName_TextBox.Multiline = true;
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(160, 35);
            this.FirstName_TextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(483, 473);
            this.Controls.Add(this.Register_Panel);
            this.Controls.Add(this.Login_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            this.Register_Panel.ResumeLayout(false);
            this.Register_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Login_Button;
        private Panel Login_Panel;
        private Label Email_Label;
        private TextBox Login_Email_TextBox;
        private Label label5;
        private Label Password_Label;
        private TextBox Login_Password_TextBox;
        private Panel Register_Panel;
        private Label label8;
        private TextBox Password_TextBox;
        private Label label7;
        private TextBox LastName_TextBox;
        private Label label6;
        private Label label2;
        private TextBox ConfirmPassword_TextBox;
        private Label label3;
        private Button Register_Button;
        private TextBox FirstName_TextBox;
        private LinkLabel AccountLabel;
        private Label Email;
        private TextBox Email_TextBox;
        private LinkLabel LoginLabel;
    }
}