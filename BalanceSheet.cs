using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class BalanceSheet : Form
    {
        public BalanceSheet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in dbe.debits where u.AccountNo == b select u);
            dataGridView1.DataSource = item.ToList();
            var item1 = (from u in dbe.Deposits where u.AccountNo == b select u);
            dataGridView2.DataSource = item1.ToList();
           
        }
    }
}
