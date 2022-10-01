using Expense.Application.Auth.Expense.Commands;
using MediatR;

namespace ExpenseAppUI.Forms
{
    public partial class IncomeForm : Form
    {
        private readonly IMediator _mediator;

        public IncomeForm(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private void IncomeSave_Button_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTimePicker_IncomeForm.Value;
            double amount = double.Parse(IncomeAmount_TextBox.Text);
            string type = "Income";
            string description = IncomeDescription_TextBox.Text;
            string category = IncomeCategory_TextBox.Text;
            int userId = Form1.Id;

            _mediator.Send(new AddExpenseCommand(category, description, amount, userId, type, dateTime));
        }

        private void IncomeClose_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
