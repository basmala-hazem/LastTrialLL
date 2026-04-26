namespace oop_Project
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            panel1 = new Panel();
            label6 = new Label();
            lnklblforgetpass = new LinkLabel();
            lblerror = new Label();
            label3 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            textBox2 = new TextBox();
            label4 = new Label();
            panel9 = new Panel();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            label5 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtname = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label7 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lnklblforgetpass);
            panel1.Controls.Add(lblerror);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(422, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 340);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(100, 33);
            label6.Name = "label6";
            label6.Size = new Size(139, 18);
            label6.TabIndex = 14;
            label6.Text = "Log in to continue";
            // 
            // lnklblforgetpass
            // 
            lnklblforgetpass.ActiveLinkColor = Color.Goldenrod;
            lnklblforgetpass.AutoSize = true;
            lnklblforgetpass.BackColor = Color.Transparent;
            lnklblforgetpass.Cursor = Cursors.Hand;
            lnklblforgetpass.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnklblforgetpass.LinkBehavior = LinkBehavior.NeverUnderline;
            lnklblforgetpass.LinkColor = Color.Black;
            lnklblforgetpass.Location = new Point(52, 248);
            lnklblforgetpass.Name = "lnklblforgetpass";
            lnklblforgetpass.Size = new Size(123, 16);
            lnklblforgetpass.TabIndex = 13;
            lnklblforgetpass.TabStop = true;
            lnklblforgetpass.Text = "Forget My Password";
            lnklblforgetpass.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.ForeColor = Color.FromArgb(192, 0, 0);
            lblerror.Location = new Point(35, 260);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(0, 15);
            lblerror.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 9);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 2;
            label3.Text = "Welcome Back!";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(52, 184);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 2);
            panel6.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(2, 78);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 2);
            panel7.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Controls.Add(textBox2);
            panel8.Location = new Point(2, 61);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(249, 22);
            panel8.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(0, 0);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 19);
            textBox2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(-1, 45);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox3);
            panel9.Controls.Add(txtPassword);
            panel9.Location = new Point(52, 166);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(249, 22);
            panel9.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(233, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(1, 3);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(230, 15);
            txtPassword.TabIndex = 0;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 151);
            label5.Name = "label5";
            label5.Size = new Size(62, 16);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(52, 218);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(249, 27);
            button1.TabIndex = 7;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(55, 109);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 2);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(2, 78);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 2);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(2, 61);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(249, 22);
            panel5.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 19);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-1, 45);
            label2.Name = "label2";
            label2.Size = new Size(66, 16);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtname);
            panel2.Location = new Point(55, 92);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 22);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_user_male_24;
            pictureBox2.Location = new Point(230, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 14);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // txtname
            // 
            txtname.BorderStyle = BorderStyle.None;
            txtname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(0, -1);
            txtname.Margin = new Padding(3, 2, 3, 2);
            txtname.Name = "txtname";
            txtname.Size = new Size(230, 19);
            txtname.TabIndex = 0;
            txtname.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 76);
            label1.Name = "label1";
            label1.Size = new Size(66, 16);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Black_and_White_Minimalist_GYM_Center_Logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 2;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(772, 340);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private TextBox txtname;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private TextBox textBox2;
        private Label label4;
        private Panel panel9;
        private TextBox txtPassword;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblerror;
        private LinkLabel lnklblforgetpass;
        private Label label6;
        private Label label7;
    }
}
