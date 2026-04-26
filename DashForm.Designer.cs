namespace WindowsFormsApp1
{
    partial class MemberForm
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.planLabel = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightText = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.dweightText = new System.Windows.Forms.TextBox();
            this.DweightLabel = new System.Windows.Forms.Label();
            this.healthProblemText = new System.Windows.Forms.TextBox();
            this.Health_probLabel = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.subDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.planText = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(123, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 33);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name :";
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(718, 32);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(497, 41);
            this.nameText.TabIndex = 2;
            // 
            // ageText
            // 
            this.ageText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageText.Location = new System.Drawing.Point(718, 109);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(497, 41);
            this.ageText.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ageLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(123, 109);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(72, 33);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age :";
            this.ageLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // planLabel
            // 
            this.planLabel.AutoSize = true;
            this.planLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.planLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planLabel.Location = new System.Drawing.Point(123, 189);
            this.planLabel.Name = "planLabel";
            this.planLabel.Size = new System.Drawing.Size(74, 33);
            this.planLabel.TabIndex = 6;
            this.planLabel.Text = "Plan :";
            this.planLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // heightText
            // 
            this.heightText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightText.Location = new System.Drawing.Point(718, 264);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(497, 41);
            this.heightText.TabIndex = 9;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.heightLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(123, 272);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(104, 33);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "Height :";
            this.heightLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // weightText
            // 
            this.weightText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightText.Location = new System.Drawing.Point(718, 329);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(497, 41);
            this.weightText.TabIndex = 11;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.weightLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(123, 337);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(111, 33);
            this.weightLabel.TabIndex = 10;
            this.weightLabel.Text = "Weight :";
            // 
            // dweightText
            // 
            this.dweightText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dweightText.Location = new System.Drawing.Point(718, 406);
            this.dweightText.Name = "dweightText";
            this.dweightText.Size = new System.Drawing.Size(497, 41);
            this.dweightText.TabIndex = 13;
            // 
            // DweightLabel
            // 
            this.DweightLabel.AutoSize = true;
            this.DweightLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DweightLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DweightLabel.Location = new System.Drawing.Point(123, 414);
            this.DweightLabel.Name = "DweightLabel";
            this.DweightLabel.Size = new System.Drawing.Size(205, 33);
            this.DweightLabel.TabIndex = 12;
            this.DweightLabel.Text = "Desired Weight :";
            this.DweightLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // healthProblemText
            // 
            this.healthProblemText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthProblemText.Location = new System.Drawing.Point(718, 478);
            this.healthProblemText.Name = "healthProblemText";
            this.healthProblemText.Size = new System.Drawing.Size(497, 41);
            this.healthProblemText.TabIndex = 15;
            // 
            // Health_probLabel
            // 
            this.Health_probLabel.AutoSize = true;
            this.Health_probLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Health_probLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health_probLabel.Location = new System.Drawing.Point(123, 486);
            this.Health_probLabel.Name = "Health_probLabel";
            this.Health_probLabel.Size = new System.Drawing.Size(211, 33);
            this.Health_probLabel.TabIndex = 14;
            this.Health_probLabel.Text = "Health Problems :";
            this.Health_probLabel.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(718, 577);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(161, 42);
            this.addbtn.TabIndex = 16;
            this.addbtn.Text = "Add ";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // subDateLabel
            // 
            this.subDateLabel.AutoSize = true;
            this.subDateLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.subDateLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subDateLabel.Location = new System.Drawing.Point(123, 549);
            this.subDateLabel.Name = "subDateLabel";
            this.subDateLabel.Size = new System.Drawing.Size(230, 33);
            this.subDateLabel.TabIndex = 17;
            this.subDateLabel.Text = "Subscribtion Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(718, 530);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(497, 41);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // planText
            // 
            this.planText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planText.FormattingEnabled = true;
            this.planText.Items.AddRange(new object[] {
            "Monthly",
            "Quarterly",
            "Annual"});
            this.planText.Location = new System.Drawing.Point(718, 186);
            this.planText.Name = "planText";
            this.planText.Size = new System.Drawing.Size(497, 41);
            this.planText.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(885, 577);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1246, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.planText);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.subDateLabel);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.healthProblemText);
            this.Controls.Add(this.Health_probLabel);
            this.Controls.Add(this.dweightText);
            this.Controls.Add(this.DweightLabel);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.planLabel);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Name = "MemberForm";
            this.Text = "Members";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label planLabel;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox weightText;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox dweightText;
        private System.Windows.Forms.Label DweightLabel;
        private System.Windows.Forms.TextBox healthProblemText;
        private System.Windows.Forms.Label Health_probLabel;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label subDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox planText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}