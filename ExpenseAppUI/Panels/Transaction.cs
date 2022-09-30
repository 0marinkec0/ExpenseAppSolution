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

        private void Expense_Button_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddApplicationServices();
            services.AddInfrastructureServices();
            services.AddScoped<ExpenseForm>();
            ServiceProvider serviceProvider = services.BuildServiceProvider();
                
                    var form2 = serviceProvider.GetRequiredService<ExpenseForm>();
                    
                    form2.Show();
                
                //var expenseForm = new ExpenseForm(Form1.Id);
                // expenseForm.Show();

               // Program.isExpense = true;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var Id = (int)dataGridTable.CurrentRow.Cells["Column1"].Value;

            _mediator.Send(new DeleteByIdCommand(Id));

            LoadDataFromDbToDataGrid();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            LoadDataFromDbToDataGrid();
        }

        private void LoadDataFromDbToDataGrid()
        {
            dataGridTable.Rows.Clear();
            var result = _mediator.Send(new GetAllExpensesQuery(Form1.Id));

            foreach (var expense in result.Result)
            {
                dataGridTable.Rows.Add(expense.Id, expense.Category, expense.Amount,
                    expense.DateTime, expense.Type, expense.Description);
            }

            var sum = _mediator.Send(new GetExpenseAmountQuery());
            Expense_Label.Text = $"{Math.Round(sum.Result,2)}$";
        }
    }
}
