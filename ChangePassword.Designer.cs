
namespace BankingApp
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.repass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.oldpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.usrname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 655);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Retype Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Old Password";
            // 
            // repass
            // 
            this.repass.Location = new System.Drawing.Point(486, 649);
            this.repass.Name = "repass";
            this.repass.Size = new System.Drawing.Size(579, 38);
            this.repass.TabIndex = 6;
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(486, 491);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(579, 38);
            this.newpass.TabIndex = 7;
            // 
            // oldpass
            // 
            this.oldpass.Location = new System.Drawing.Point(486, 344);
            this.oldpass.Name = "oldpass";
            this.oldpass.Size = new System.Drawing.Size(579, 38);
            this.oldpass.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 779);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 102);
            this.button1.TabIndex = 9;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usrname
            // 
            this.usrname.Location = new System.Drawing.Point(486, 217);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(579, 38);
            this.usrname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 1160);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oldpass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.repass);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox repass;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox oldpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usrname;
        private System.Windows.Forms.Label label2;
    }
}