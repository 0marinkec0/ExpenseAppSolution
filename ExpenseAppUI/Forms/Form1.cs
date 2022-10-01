using Expense.Application.Auth.Login;
using Expense.Application.Auth.Register;
using MediatR;

namespace ExpenseAppUI
{
    public partial class Form1 : Form
    {
        private readonly IMediator _mediator;
        public static int Id;

        public Form1(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Login_Panel.Visible = true;
            Register_Panel.Visible = false;
        }

        private void AccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Panel.Visible = false;
            Login_Panel.Left = 504;

            Register_Panel.Visible = true;
            Register_Panel.Left = 41;
        }

        private void LoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Panel.Visible = true;
            Login_Panel.Left = 41;

            Register_Panel.Visible = false;
            Register_Panel.Left = 504;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string email = Login_Email_TextBox.Text;
            string password = textBox1.Text;

            var result = _mediator.Send(new LoginCommand(email, password));
            if (result.Result.Success)
            {
                Id = result.Result.Id;
                Program.isValid = true;
                this.Close();
            }
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            string email = Email_TextBox.Text;
            string fname = FirstName_TextBox.Text;
            string lname = LastName_TextBox.Text;
            string pass = Password_TextBox.Text;
            string passc = ConfirmPassword_TextBox.Text;

            var result = _mediator.Send(new RegisterCommand(email, fname, lname,pass));    
            if (result.Result.Success)
                MessageBox.Show("REGISTER SUCCESSFULL");
        }
    }
}