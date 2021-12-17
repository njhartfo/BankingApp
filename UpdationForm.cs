using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class UpdationForm : Form
    {
        banking_dbEntities1 dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;


        public UpdationForm()
        {
            InitializeComponent();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(acctxt.Text);
            var item = dbe.userAccounts.Where(a => a.Account_no == accno);
            foreach (var item1 in item) 
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities1();
            var item = dbe.userAccounts.Where(a => a.Name == nametxt.Text);
            foreach (var item1 in item) 
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccounts.Where(a => a.Account_no == accno).FirstOrDefault();
            acctxt.Text = item.Account_no.ToString();
            nametxt.Text = item.Name;
            phonetxt.Text = item.PhoneNo;
            addresstxt.Text = item.Address;
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            disttxt.Text = item.District;
            statetxt.Text = item.State;

            if (item.Gender == "male")
            {
                maleradio.Checked = true;
            }
            else if (item.Gender == "female")
            {
                femaleradio.Checked = true;
            }
            else if (item.Gender == "other")
            {
                otherradio.Checked = true;
            }

            if (item.marital_status == "married")
            {
                marriedradio.Checked = true;
            }
            else if (item.marital_status == "single") 
            {
                singleradio.Checked = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dbe = new banking_dbEntities1();
            decimal a = Convert.ToDecimal(acctxt.Text);
            userAccount acc = dbe.userAccounts.First(s => s.Account_no.Equals(a));
            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbe = new banking_dbEntities1();
            decimal accountno = Convert.ToDecimal(acctxt.Text);
            userAccount useraccount = dbe.userAccounts.First(s => s.Account_no.Equals(acctxt.Text));
            useraccount.Name = nametxt.Text;
            useraccount.Date = dateTimePicker1.Value.ToString();
            useraccount.PhoneNo = phonetxt.Text;
            if (maleradio.Checked == true) { useraccount.Gender = "male"; }
            else if (femaleradio.Checked == true) { useraccount.Gender = "female"; }
            else if (otherradio.Checked == true) { useraccount.Gender = "other"; }

            if (marriedradio.Checked == true) { useraccount.marital_status = "married"; }
            else if (singleradio.Checked == true) { useraccount.marital_status = "single"; }

            Image img = pictureBox1.Image;
            if (img.RawFormat != null) 
            {
                if (ms != null) 
                {
                    img.Save(ms, img.RawFormat);
                    useraccount.Picture = ms.ToArray();
                }
            }

            useraccount.Address = addresstxt.Text;
            useraccount.District = disttxt.Text;
            useraccount.State = statetxt.Text;
            dbe.SaveChanges();
            MessageBox.Show("Changes Save Successfully");
        }
    }
}
