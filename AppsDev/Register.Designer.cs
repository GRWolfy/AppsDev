
namespace AppsDev
{
   partial class Register
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
         this.btnSave = new System.Windows.Forms.Button();
         this.txtFirstName = new System.Windows.Forms.TextBox();
         this.rbtnMale = new System.Windows.Forms.RadioButton();
         this.cmboxStatus = new System.Windows.Forms.ComboBox();
         this.rbtnFemale = new System.Windows.Forms.RadioButton();
         this.rbtnOther = new System.Windows.Forms.RadioButton();
         this.btnBack = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.txtLastName = new System.Windows.Forms.TextBox();
         this.txtAge = new System.Windows.Forms.TextBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.labelPassword = new System.Windows.Forms.Label();
         this.labelUsername = new System.Windows.Forms.Label();
         this.labelEmail = new System.Windows.Forms.Label();
         this.txtConfirmPassword = new System.Windows.Forms.TextBox();
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.txtUsername = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(564, 25);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(90, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "First Name:";
         // 
         // btnSave
         // 
         this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.Location = new System.Drawing.Point(664, 566);
         this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(310, 82);
         this.btnSave.TabIndex = 1;
         this.btnSave.Text = "Register";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // txtFirstName
         // 
         this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtFirstName.Location = new System.Drawing.Point(741, 25);
         this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtFirstName.Multiline = true;
         this.txtFirstName.Name = "txtFirstName";
         this.txtFirstName.Size = new System.Drawing.Size(282, 38);
         this.txtFirstName.TabIndex = 2;
         this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
         // 
         // rbtnMale
         // 
         this.rbtnMale.AutoSize = true;
         this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbtnMale.Location = new System.Drawing.Point(740, 192);
         this.rbtnMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.rbtnMale.Name = "rbtnMale";
         this.rbtnMale.Size = new System.Drawing.Size(61, 24);
         this.rbtnMale.TabIndex = 3;
         this.rbtnMale.TabStop = true;
         this.rbtnMale.Text = "Male";
         this.rbtnMale.UseVisualStyleBackColor = true;
         // 
         // cmboxStatus
         // 
         this.cmboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmboxStatus.FormattingEnabled = true;
         this.cmboxStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widowed"});
         this.cmboxStatus.Location = new System.Drawing.Point(741, 245);
         this.cmboxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.cmboxStatus.Name = "cmboxStatus";
         this.cmboxStatus.Size = new System.Drawing.Size(178, 28);
         this.cmboxStatus.TabIndex = 4;
         this.cmboxStatus.SelectedValueChanged += new System.EventHandler(this.cmboxStatus_SelectedValueChanged);
         // 
         // rbtnFemale
         // 
         this.rbtnFemale.AutoSize = true;
         this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbtnFemale.Location = new System.Drawing.Point(840, 192);
         this.rbtnFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.rbtnFemale.Name = "rbtnFemale";
         this.rbtnFemale.Size = new System.Drawing.Size(80, 24);
         this.rbtnFemale.TabIndex = 5;
         this.rbtnFemale.TabStop = true;
         this.rbtnFemale.Text = "Female";
         this.rbtnFemale.UseVisualStyleBackColor = true;
         // 
         // rbtnOther
         // 
         this.rbtnOther.AutoSize = true;
         this.rbtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbtnOther.Location = new System.Drawing.Point(957, 192);
         this.rbtnOther.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.rbtnOther.Name = "rbtnOther";
         this.rbtnOther.Size = new System.Drawing.Size(67, 24);
         this.rbtnOther.TabIndex = 6;
         this.rbtnOther.TabStop = true;
         this.rbtnOther.Text = "Other";
         this.rbtnOther.UseVisualStyleBackColor = true;
         // 
         // btnBack
         // 
         this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnBack.Location = new System.Drawing.Point(1070, 17);
         this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnBack.Name = "btnBack";
         this.btnBack.Size = new System.Drawing.Size(112, 38);
         this.btnBack.TabIndex = 7;
         this.btnBack.Text = "Back";
         this.btnBack.UseVisualStyleBackColor = true;
         this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(564, 77);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(90, 20);
         this.label2.TabIndex = 8;
         this.label2.Text = "Last Name:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(564, 135);
         this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(42, 20);
         this.label6.TabIndex = 12;
         this.label6.Text = "Age:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(561, 249);
         this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(60, 20);
         this.label7.TabIndex = 13;
         this.label7.Text = "Status:";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.Location = new System.Drawing.Point(561, 195);
         this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(67, 20);
         this.label9.TabIndex = 15;
         this.label9.Text = "Gender:";
         // 
         // txtLastName
         // 
         this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtLastName.Location = new System.Drawing.Point(741, 77);
         this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtLastName.Multiline = true;
         this.txtLastName.Name = "txtLastName";
         this.txtLastName.Size = new System.Drawing.Size(282, 38);
         this.txtLastName.TabIndex = 16;
         this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
         // 
         // txtAge
         // 
         this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtAge.Location = new System.Drawing.Point(741, 131);
         this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtAge.Multiline = true;
         this.txtAge.Name = "txtAge";
         this.txtAge.Size = new System.Drawing.Size(282, 38);
         this.txtAge.TabIndex = 17;
         this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(516, 697);
         this.panel1.TabIndex = 25;
         // 
         // labelPassword
         // 
         this.labelPassword.AutoSize = true;
         this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelPassword.Location = new System.Drawing.Point(1034, 425);
         this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.labelPassword.Name = "labelPassword";
         this.labelPassword.Size = new System.Drawing.Size(16, 13);
         this.labelPassword.TabIndex = 24;
         this.labelPassword.Text = "...";
         // 
         // labelUsername
         // 
         this.labelUsername.AutoSize = true;
         this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelUsername.Location = new System.Drawing.Point(1034, 322);
         this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.labelUsername.Name = "labelUsername";
         this.labelUsername.Size = new System.Drawing.Size(16, 13);
         this.labelUsername.TabIndex = 23;
         this.labelUsername.Text = "...";
         // 
         // labelEmail
         // 
         this.labelEmail.AutoSize = true;
         this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelEmail.Location = new System.Drawing.Point(1034, 485);
         this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.labelEmail.Name = "labelEmail";
         this.labelEmail.Size = new System.Drawing.Size(16, 13);
         this.labelEmail.TabIndex = 22;
         this.labelEmail.Text = "...";
         // 
         // txtConfirmPassword
         // 
         this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtConfirmPassword.Location = new System.Drawing.Point(741, 414);
         this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtConfirmPassword.Name = "txtConfirmPassword";
         this.txtConfirmPassword.PasswordChar = '•';
         this.txtConfirmPassword.Size = new System.Drawing.Size(282, 26);
         this.txtConfirmPassword.TabIndex = 21;
         this.txtConfirmPassword.UseSystemPasswordChar = true;
         this.txtConfirmPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyUp);
         // 
         // txtEmail
         // 
         this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmail.Location = new System.Drawing.Point(741, 474);
         this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtEmail.Multiline = true;
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(282, 38);
         this.txtEmail.TabIndex = 20;
         this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyUp);
         // 
         // txtPassword
         // 
         this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPassword.Location = new System.Drawing.Point(741, 360);
         this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '•';
         this.txtPassword.Size = new System.Drawing.Size(282, 26);
         this.txtPassword.TabIndex = 19;
         this.txtPassword.UseSystemPasswordChar = true;
         this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
         // 
         // txtUsername
         // 
         this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtUsername.Location = new System.Drawing.Point(741, 311);
         this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtUsername.Multiline = true;
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(282, 38);
         this.txtUsername.TabIndex = 18;
         this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyUp);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(555, 478);
         this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(52, 20);
         this.label8.TabIndex = 14;
         this.label8.Text = "Email:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(520, 418);
         this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(141, 20);
         this.label5.TabIndex = 11;
         this.label5.Text = "Confirm Password:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(561, 365);
         this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(82, 20);
         this.label4.TabIndex = 10;
         this.label4.Text = "Password:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(561, 315);
         this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(87, 20);
         this.label3.TabIndex = 9;
         this.label3.Text = "Username:";
         // 
         // Register
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 692);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.labelPassword);
         this.Controls.Add(this.labelUsername);
         this.Controls.Add(this.labelEmail);
         this.Controls.Add(this.txtConfirmPassword);
         this.Controls.Add(this.txtEmail);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.txtAge);
         this.Controls.Add(this.txtLastName);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnBack);
         this.Controls.Add(this.rbtnOther);
         this.Controls.Add(this.rbtnFemale);
         this.Controls.Add(this.cmboxStatus);
         this.Controls.Add(this.rbtnMale);
         this.Controls.Add(this.txtFirstName);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Register";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Register";
         this.Load += new System.EventHandler(this.Register_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.TextBox txtFirstName;
      private System.Windows.Forms.RadioButton rbtnMale;
      private System.Windows.Forms.ComboBox cmboxStatus;
      private System.Windows.Forms.RadioButton rbtnFemale;
      private System.Windows.Forms.RadioButton rbtnOther;
      private System.Windows.Forms.Button btnBack;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox txtLastName;
      private System.Windows.Forms.TextBox txtAge;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label labelPassword;
      private System.Windows.Forms.Label labelUsername;
      private System.Windows.Forms.Label labelEmail;
      private System.Windows.Forms.TextBox txtConfirmPassword;
      private System.Windows.Forms.TextBox txtEmail;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.TextBox txtUsername;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
   }
}