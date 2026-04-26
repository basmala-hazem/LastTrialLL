namespace WindowsFormsApp1
{
    partial class Changepass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.check_shownewpass = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.lbl_Newpass = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.check_showconfirmnewpass = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Confirmnewpass = new System.Windows.Forms.TextBox();
            this.lbl_Confirm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.check_showconfirmnewpass);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.txt_Confirmnewpass);
            this.panel1.Controls.Add(this.lbl_Confirm);
            this.panel1.Controls.Add(this.lbl_error);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.check_shownewpass);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.txt_NewPass);
            this.panel1.Controls.Add(this.lbl_Newpass);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.txt_Code);
            this.panel1.Controls.Add(this.lbl_Code);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(478, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 444);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(28, 395);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 19);
            this.lbl_error.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(64, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Change the password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome Back";
            // 
            // check_shownewpass
            // 
            this.check_shownewpass.AutoSize = true;
            this.check_shownewpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_shownewpass.Location = new System.Drawing.Point(50, 213);
            this.check_shownewpass.Name = "check_shownewpass";
            this.check_shownewpass.Size = new System.Drawing.Size(146, 23);
            this.check_shownewpass.TabIndex = 8;
            this.check_shownewpass.Text = "Show Password";
            this.check_shownewpass.UseVisualStyleBackColor = true;
            this.check_shownewpass.CheckedChanged += new System.EventHandler(this.check_showpass_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(46, 396);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 19);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(50, 203);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(263, 1);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NewPass.Location = new System.Drawing.Point(50, 184);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.PasswordChar = '*';
            this.txt_NewPass.Size = new System.Drawing.Size(263, 20);
            this.txt_NewPass.TabIndex = 4;
            // 
            // lbl_Newpass
            // 
            this.lbl_Newpass.AutoSize = true;
            this.lbl_Newpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Newpass.Location = new System.Drawing.Point(46, 159);
            this.lbl_Newpass.Name = "lbl_Newpass";
            this.lbl_Newpass.Size = new System.Drawing.Size(138, 22);
            this.lbl_Newpass.TabIndex = 3;
            this.lbl_Newpass.Text = "New password";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 1);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // txt_Code
            // 
            this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Code.Location = new System.Drawing.Point(50, 111);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(263, 20);
            this.txt_Code.TabIndex = 1;
            this.txt_Code.TextChanged += new System.EventHandler(this.txt_Code_TextChanged);
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Code.Location = new System.Drawing.Point(46, 86);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(60, 22);
            this.lbl_Code.TabIndex = 0;
            this.lbl_Code.Text = "Code\r\n";
            // 
            // check_showconfirmnewpass
            // 
            this.check_showconfirmnewpass.AutoSize = true;
            this.check_showconfirmnewpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_showconfirmnewpass.Location = new System.Drawing.Point(50, 310);
            this.check_showconfirmnewpass.Name = "check_showconfirmnewpass";
            this.check_showconfirmnewpass.Size = new System.Drawing.Size(146, 23);
            this.check_showconfirmnewpass.TabIndex = 15;
            this.check_showconfirmnewpass.Text = "Show Password";
            this.check_showconfirmnewpass.UseVisualStyleBackColor = true;
            this.check_showconfirmnewpass.CheckedChanged += new System.EventHandler(this.check_showconfirmnewpass_CheckedChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(50, 300);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(263, 1);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // txt_Confirmnewpass
            // 
            this.txt_Confirmnewpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Confirmnewpass.Location = new System.Drawing.Point(50, 281);
            this.txt_Confirmnewpass.Name = "txt_Confirmnewpass";
            this.txt_Confirmnewpass.PasswordChar = '*';
            this.txt_Confirmnewpass.Size = new System.Drawing.Size(263, 20);
            this.txt_Confirmnewpass.TabIndex = 13;
            // 
            // lbl_Confirm
            // 
            this.lbl_Confirm.AutoSize = true;
            this.lbl_Confirm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm.Location = new System.Drawing.Point(46, 256);
            this.lbl_Confirm.Name = "lbl_Confirm";
            this.lbl_Confirm.Size = new System.Drawing.Size(210, 22);
            this.lbl_Confirm.TabIndex = 12;
            this.lbl_Confirm.Text = "Confirm new password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(50, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Changepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(878, 444);
            this.Controls.Add(this.panel1);
            this.Name = "Changepass";
            this.Text = "Changepass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_shownewpass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.Label lbl_Newpass;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.CheckBox check_showconfirmnewpass;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox txt_Confirmnewpass;
        private System.Windows.Forms.Label lbl_Confirm;
        private System.Windows.Forms.Button button1;
    }
}