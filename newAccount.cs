﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities1 BSE;
        MemoryStream ms;

        public newAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            comboBox1.Items.Add("Indiana");
        }

        private void loadaccount()
        {
            BSE = new banking_dbEntities1();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_no + 1;
            accnotext.Text = Convert.ToString(no);
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opebdlg = new OpenFileDialog();
            if (opebdlg.ShowDialog() == DialogResult.OK) 
            {
                Image img = Image.FromFile(opebdlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maleradio.Checked)
            {
                gender = "male";
            }
            else if (femaleradio.Checked)
            {
                gender = "female";
            }
            else if (otherradio.Checked) 
            {
                gender = "other";
            }
            if (marriedradio.Checked)
            {
                m_status = "married";
            }
            else if (singleradio.Checked)
            {
                m_status = "single";
            }

            BSE = new banking_dbEntities1();
            userAccount acc = new userAccount();
            acc.Account_no = Convert.ToDecimal(accnotext.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = phonetxt.Text;
            acc.Address = addtxt.Text;
            acc.District = disttxt.Text;
            acc.State = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.marital_status = m_status;
            acc.balance = Convert.ToDecimal(balancetxt.Text);
            acc.Date = datelbl.Text;
            acc.Picture = ms.ToArray();
            BSE.userAccounts.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("File saved.");
        }
    }
}
