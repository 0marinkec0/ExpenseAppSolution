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
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Transaction());

            //OBRISATI - TEST
            MessageBox.Show(Id.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Dashboard());
        }
    }
}
