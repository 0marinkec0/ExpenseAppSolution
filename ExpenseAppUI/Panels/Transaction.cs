using ExpenseAppUI.Forms;
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
            var expenseForm = new ExpenseForm();
            expenseForm.Show();
        }
    }
}
