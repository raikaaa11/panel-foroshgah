namespace panel_foroshgah
{
    partial class Form1
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
            Loginbutton = new Button();
            UsernametextBox = new TextBox();
            Usernamelabel = new Label();
            PasswordtextBox = new TextBox();
            Passwordlabel = new Label();
            FirstNamelabel = new Label();
            LastNamelabel = new Label();
            PhonNumberlabel = new Label();
            NationalCodelabel = new Label();
            FirstNametextBox = new TextBox();
            LastNametextBox = new TextBox();
            PhoneNumbertextBox = new TextBox();
            NationalCodetextBox = new TextBox();
            Registerbutton = new Button();
            SuspendLayout();
            // 
            // Loginbutton
            // 
            Loginbutton.Location = new Point(12, 129);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(284, 39);
            Loginbutton.TabIndex = 0;
            Loginbutton.Text = " Login";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += login;
            // 
            // UsernametextBox
            // 
            UsernametextBox.Location = new Point(94, 38);
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.Size = new Size(202, 27);
            UsernametextBox.TabIndex = 1;
            UsernametextBox.TextChanged += UsernametextBox1_TextChanged;
            // 
            // Usernamelabel
            // 
            Usernamelabel.AutoSize = true;
            Usernamelabel.Location = new Point(12, 38);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(75, 20);
            Usernamelabel.TabIndex = 2;
            Usernamelabel.Text = "Username";
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(94, 78);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(202, 27);
            PasswordtextBox.TabIndex = 4;
            PasswordtextBox.Click += textBox3_Click;
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(12, 81);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(70, 20);
            Passwordlabel.TabIndex = 5;
            Passwordlabel.Text = "Password";
            // 
            // FirstNamelabel
            // 
            FirstNamelabel.AutoSize = true;
            FirstNamelabel.Location = new Point(414, 16);
            FirstNamelabel.Name = "FirstNamelabel";
            FirstNamelabel.Size = new Size(76, 20);
            FirstNamelabel.TabIndex = 6;
            FirstNamelabel.Text = "FirstName";
            // 
            // LastNamelabel
            // 
            LastNamelabel.AutoSize = true;
            LastNamelabel.Location = new Point(414, 55);
            LastNamelabel.Name = "LastNamelabel";
            LastNamelabel.Size = new Size(75, 20);
            LastNamelabel.TabIndex = 7;
            LastNamelabel.Text = "LastName";
            // 
            // PhonNumberlabel
            // 
            PhonNumberlabel.AutoSize = true;
            PhonNumberlabel.Location = new Point(403, 97);
            PhonNumberlabel.Name = "PhonNumberlabel";
            PhonNumberlabel.Size = new Size(96, 20);
            PhonNumberlabel.TabIndex = 8;
            PhonNumberlabel.Text = "PhonNumber";
            // 
            // NationalCodelabel
            // 
            NationalCodelabel.AutoSize = true;
            NationalCodelabel.Location = new Point(403, 141);
            NationalCodelabel.Name = "NationalCodelabel";
            NationalCodelabel.Size = new Size(101, 20);
            NationalCodelabel.TabIndex = 9;
            NationalCodelabel.Text = "NationalCode";
            // 
            // FirstNametextBox
            // 
            FirstNametextBox.Location = new Point(520, 9);
            FirstNametextBox.Name = "FirstNametextBox";
            FirstNametextBox.Size = new Size(202, 27);
            FirstNametextBox.TabIndex = 11;
            // 
            // LastNametextBox
            // 
            LastNametextBox.Location = new Point(520, 48);
            LastNametextBox.Name = "LastNametextBox";
            LastNametextBox.Size = new Size(202, 27);
            LastNametextBox.TabIndex = 12;
            // 
            // PhoneNumbertextBox
            // 
            PhoneNumbertextBox.Location = new Point(520, 97);
            PhoneNumbertextBox.Name = "PhoneNumbertextBox";
            PhoneNumbertextBox.Size = new Size(202, 27);
            PhoneNumbertextBox.TabIndex = 13;
            PhoneNumbertextBox.TextChanged += PhoneNumbertextBox3_TextChanged;
            // 
            // NationalCodetextBox
            // 
            NationalCodetextBox.Location = new Point(520, 141);
            NationalCodetextBox.Name = "NationalCodetextBox";
            NationalCodetextBox.Size = new Size(202, 27);
            NationalCodetextBox.TabIndex = 14;
            // 
            // Registerbutton
            // 
            Registerbutton.Location = new Point(438, 195);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(284, 39);
            Registerbutton.TabIndex = 15;
            Registerbutton.Text = " Register";
            Registerbutton.UseVisualStyleBackColor = true;
            Registerbutton.Click += Register;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 258);
            Controls.Add(Registerbutton);
            Controls.Add(NationalCodetextBox);
            Controls.Add(PhoneNumbertextBox);
            Controls.Add(LastNametextBox);
            Controls.Add(FirstNametextBox);
            Controls.Add(NationalCodelabel);
            Controls.Add(PhonNumberlabel);
            Controls.Add(LastNamelabel);
            Controls.Add(FirstNamelabel);
            Controls.Add(Passwordlabel);
            Controls.Add(PasswordtextBox);
            Controls.Add(Usernamelabel);
            Controls.Add(UsernametextBox);
            Controls.Add(Loginbutton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Loginbutton;
        private TextBox UsernametextBox;
        private Label Usernamelabel;
        private TextBox PasswordtextBox;
        private Label Passwordlabel;
        private Label FirstNamelabel;
        private Label LastNamelabel;
        private Label PhonNumberlabel;
        private Label NationalCodelabel;
        private Label label7;
        private TextBox FirstNametextBox;
        private TextBox LastNametextBox;
        private TextBox PhoneNumbertextBox;
        private TextBox NationalCodetextBox;
        private Button Registerbutton;
        private TextBox textBox5;
    }
}
