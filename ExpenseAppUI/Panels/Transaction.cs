using Expense.Application;
using Expense.Infrastructure;
using Expense.Infrastructure.Identity;
using ExpenseAppUI.Forms;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseAppUI
{
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
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

        }
    }
}
