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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            loaddate();
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccounts where u.Account_no == b select u).FirstOrDefault();
            nametxt.Text = item.Name;
            amounttxt.Text = Convert.ToString(item.balance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccounts where u.Account_no == b select u).FirstOrDefault();
            decimal b1 = Convert.ToDecimal(item.balance);
            decimal totalbalance = Convert.ToDecimal(transfertxt.Text);
            decimal transferacc = Convert.ToDecimal(desaccounttxt.Text);
            if (b1 > totalbalance) 
            {
                userAccount item2 = (from u in dbe.userAccounts where u.Account_no == transferacc select u).FirstOrDefault();
                item2.balance = item2.balance + totalbalance;
                item.balance = item.balance - totalbalance;
                //dbe.SaveChanges();
                Transfer transfer = new Transfer();
                transfer.Account_No = Convert.ToDecimal(fromacctxt.Text);
                transfer.ToTransfer = Convert.ToDecimal(desaccounttxt.Text);
                transfer.Date = DateTime.UtcNow.ToString();
                transfer.Name = nametxt.Text;
                transfer.balance = Convert.ToDecimal(transfertxt.Text);

                dbe.Transfers.Add(transfer);
                dbe.SaveChanges();
                MessageBox.Show("Money Transferred Successfully");

            }
        }
    }
}
