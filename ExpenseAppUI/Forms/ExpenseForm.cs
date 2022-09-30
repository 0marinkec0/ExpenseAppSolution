using Expense.Application.Auth.Expense.Commands;
using MediatR;
using System.Transactions;

namespace ExpenseAppUI.Forms
{
    public partial class ExpenseForm : Form
    {
        private readonly IMediator _mediator;

        public ExpenseForm(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTimePicker_ExpenseForm.Value;
            double amount = double.Parse(Amount_TextBox.Text);
            string type = "Expense";
            string description = Description_TextBox.Text;
            string category = Category_TextBox.Text;
            int userId = Form1.Id;

            _mediator.Send(new AddExpenseCommand(category, description, amount, userId, type, dateTime));           
        }
    }
}
