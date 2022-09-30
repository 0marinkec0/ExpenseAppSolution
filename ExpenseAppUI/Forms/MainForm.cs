using Expense.Application;
using Expense.Infrastructure;
using ExpenseAppUI.Forms;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ExpenseAppUI
{
    public partial class MainForm : Form
    {
        private int Id;

        public MainForm(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void Dashboard_Btn_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowTransaction();
        }

        private void Transaction_Button_Click(object sender, EventArgs e)
        {
            ShowTransaction();
        }

        private void ShowTransaction()
        {
            var services = new ServiceCollection();
            services.AddApplicationServices();
            services.AddInfrastructureServices();
            services.AddScoped<Transaction>();
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            var form2 = serviceProvider.GetRequiredService<Transaction>();


            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(form2);
            // MainPanel.Controls.Add(new Transaction());

            //OBRISATI - TEST
            //MessageBox.Show(Id.ToString());
        }

        private void ShowDashboard()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Dashboard());
        }
    }
}
