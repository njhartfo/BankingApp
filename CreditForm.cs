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
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Check");
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 context = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts where u.Account_no == b select u).FirstOrDefault();
            nametxt.Text = item.Name;
            oldbalancetxt.Text = Convert.ToString(item.balance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 context = new banking_dbEntities1();
            newAccount acc = new newAccount();
            Deposit dp = new Deposit();
            dp.AccountNo = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbalancetxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DipAmount = Convert.ToDecimal(amounttxt.Text);
            context.Deposits.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts where u.Account_no == b select u).FirstOrDefault();
            item.balance = item.balance + Convert.ToDecimal(amounttxt.Text);
            context.SaveChanges();
            MessageBox.Show("Money depositied successfully");
        }
    }
}
