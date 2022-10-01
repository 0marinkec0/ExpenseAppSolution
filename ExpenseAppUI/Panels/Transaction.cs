using Expense.Application;
using Expense.Application.Expense.Commands;
using Expense.Application.Expense.Queries;
using Expense.Infrastructure;
using ExpenseAppUI.Forms;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ExpenseAppUI
{
    public partial class Transaction : UserControl
    {
        private readonly IMediator _mediator;

        public Transaction(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            LoadDataFromDbToDataGrid();
        }

        private void Expense_Button_Click(object sender, EventArgs e)
        {
            new Forms.ExpenseForm(_mediator).ShowDialog();
        }

        private void Income_Button_Click(object sender, EventArgs e)
        {
            new Forms.IncomeForm(_mediator).ShowDialog();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var Id = (int)dataGridTable.CurrentRow.Cells["Column1"].Value;

            _mediator.Send(new DeleteByIdCommand(Id));

            LoadDataFromDbToDataGrid();
        }

         void LoadDataFromDbToDataGrid()
        {
            dataGridTable.Rows.Clear();

            var result = _mediator.Send(new GetAllExpensesQuery(Form1.Id));

            foreach (var expense in result.Result)
            {
                dataGridTable.Rows.Add(expense.Id, expense.Category, expense.Amount,
                    expense.DateTime, expense.Type, expense.Description);
            }

            var expenseSum = _mediator.Send(new GetExpenseAmountQuery());
            var incomeSum = _mediator.Send(new GetIncomeAmountQuery());

            Expense_Label.Text = $"{Math.Round(expenseSum.Result,2)}$";
            Income_Label.Text = $"{Math.Round(incomeSum.Result, 2)}$";
        }
    }
}
