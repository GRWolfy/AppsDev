
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
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.txtLastName = new System.Windows.Forms.TextBox();
         this.txtAge = new System.Windows.Forms.TextBox();
         this.txtUsername = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.txtConfirmPassword = new System.Windows.Forms.TextBox();
         this.labelEmail = new System.Windows.Forms.Label();
         this.labelUsername = new System.Windows.Forms.Label();
         this.labelPassword = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(44, 115);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(60, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "First Name:";
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(318, 313);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(207, 53);
         this.btnSave.TabIndex = 1;
         this.btnSave.Text = "Register";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // txtFirstName
         // 
         this.txtFirstName.Location = new System.Drawing.Point(129, 115);
         this.txtFirstName.Multiline = true;
         this.txtFirstName.Name = "txtFirstName";
         this.txtFirstName.Size = new System.Drawing.Size(189, 20);
         this.txtFirstName.TabIndex = 2;
         // 
         // rbtnMale
         // 
         this.rbtnMale.AutoSize = true;
         this.rbtnMale.Location = new System.Drawing.Point(128, 227);
         this.rbtnMale.Name = "rbtnMale";
         this.rbtnMale.Size = new System.Drawing.Size(48, 17);
         this.rbtnMale.TabIndex = 3;
         this.rbtnMale.TabStop = true;
         this.rbtnMale.Text = "Male";
         this.rbtnMale.UseVisualStyleBackColor = true;
         // 
         // cmboxStatus
         // 
         this.cmboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmboxStatus.FormattingEnabled = true;
         this.cmboxStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widowed"});
         this.cmboxStatus.Location = new System.Drawing.Point(129, 258);
         this.cmboxStatus.Name = "cmboxStatus";
         this.cmboxStatus.Size = new System.Drawing.Size(120, 21);
         this.cmboxStatus.TabIndex = 4;
         // 
         // rbtnFemale
         // 
         this.rbtnFemale.AutoSize = true;
         this.rbtnFemale.Location = new System.Drawing.Point(182, 227);
         this.rbtnFemale.Name = "rbtnFemale";
         this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
         this.rbtnFemale.TabIndex = 5;
         this.rbtnFemale.TabStop = true;
         this.rbtnFemale.Text = "Female";
         this.rbtnFemale.UseVisualStyleBackColor = true;
         // 
         // rbtnOther
         // 
         this.rbtnOther.AutoSize = true;
         this.rbtnOther.Location = new System.Drawing.Point(249, 227);
         this.rbtnOther.Name = "rbtnOther";
         this.rbtnOther.Size = new System.Drawing.Size(51, 17);
         this.rbtnOther.TabIndex = 6;
         this.rbtnOther.TabStop = true;
         this.rbtnOther.Text = "Other";
         this.rbtnOther.UseVisualStyleBackColor = true;
         // 
         // btnBack
         // 
         this.btnBack.Location = new System.Drawing.Point(12, 12);
         this.btnBack.Name = "btnBack";
         this.btnBack.Size = new System.Drawing.Size(75, 23);
         this.btnBack.TabIndex = 7;
         this.btnBack.Text = "Back";
         this.btnBack.UseVisualStyleBackColor = true;
         this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(44, 149);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(61, 13);
         this.label2.TabIndex = 8;
         this.label2.Text = "Last Name:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(362, 116);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(58, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "Username:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(362, 145);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(56, 13);
         this.label4.TabIndex = 10;
         this.label4.Text = "Password:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(362, 183);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(94, 13);
         this.label5.TabIndex = 11;
         this.label5.Text = "Confirm Password:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(44, 184);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(29, 13);
         this.label6.TabIndex = 12;
         this.label6.Text = "Age:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(44, 258);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(40, 13);
         this.label7.TabIndex = 13;
         this.label7.Text = "Status:";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(362, 222);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(35, 13);
         this.label8.TabIndex = 14;
         this.label8.Text = "Email:";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(44, 226);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(45, 13);
         this.label9.TabIndex = 15;
         this.label9.Text = "Gender:";
         // 
         // txtLastName
         // 
         this.txtLastName.Location = new System.Drawing.Point(129, 149);
         this.txtLastName.Multiline = true;
         this.txtLastName.Name = "txtLastName";
         this.txtLastName.Size = new System.Drawing.Size(189, 20);
         this.txtLastName.TabIndex = 16;
         // 
         // txtAge
         // 
         this.txtAge.Location = new System.Drawing.Point(129, 184);
         this.txtAge.Multiline = true;
         this.txtAge.Name = "txtAge";
         this.txtAge.Size = new System.Drawing.Size(189, 20);
         this.txtAge.TabIndex = 17;
         this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
         // 
         // txtUsername
         // 
         this.txtUsername.Location = new System.Drawing.Point(462, 113);
         this.txtUsername.Multiline = true;
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(189, 20);
         this.txtUsername.TabIndex = 18;
         this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyUp);
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(462, 142);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '•';
         this.txtPassword.Size = new System.Drawing.Size(189, 20);
         this.txtPassword.TabIndex = 19;
         this.txtPassword.UseSystemPasswordChar = true;
         this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
         // 
         // txtEmail
         // 
         this.txtEmail.Location = new System.Drawing.Point(462, 219);
         this.txtEmail.Multiline = true;
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(189, 20);
         this.txtEmail.TabIndex = 20;
         this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
         // 
         // txtConfirmPassword
         // 
         this.txtConfirmPassword.Location = new System.Drawing.Point(462, 180);
         this.txtConfirmPassword.Name = "txtConfirmPassword";
         this.txtConfirmPassword.PasswordChar = '•';
         this.txtConfirmPassword.Size = new System.Drawing.Size(189, 20);
         this.txtConfirmPassword.TabIndex = 21;
         this.txtConfirmPassword.UseSystemPasswordChar = true;
         this.txtConfirmPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyUp);
         // 
         // labelEmail
         // 
         this.labelEmail.AutoSize = true;
         this.labelEmail.Location = new System.Drawing.Point(657, 226);
         this.labelEmail.Name = "labelEmail";
         this.labelEmail.Size = new System.Drawing.Size(16, 13);
         this.labelEmail.TabIndex = 22;
         this.labelEmail.Text = "...";
         // 
         // labelUsername
         // 
         this.labelUsername.AutoSize = true;
         this.labelUsername.Location = new System.Drawing.Point(657, 120);
         this.labelUsername.Name = "labelUsername";
         this.labelUsername.Size = new System.Drawing.Size(16, 13);
         this.labelUsername.TabIndex = 23;
         this.labelUsername.Text = "...";
         // 
         // labelPassword
         // 
         this.labelPassword.AutoSize = true;
         this.labelPassword.Location = new System.Drawing.Point(657, 187);
         this.labelPassword.Name = "labelPassword";
         this.labelPassword.Size = new System.Drawing.Size(16, 13);
         this.labelPassword.TabIndex = 24;
         this.labelPassword.Text = "...";
         // 
         // Register
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
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
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "Register";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Register";
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
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox txtLastName;
      private System.Windows.Forms.TextBox txtAge;
      private System.Windows.Forms.TextBox txtUsername;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.TextBox txtEmail;
      private System.Windows.Forms.TextBox txtConfirmPassword;
      private System.Windows.Forms.Label labelEmail;
      private System.Windows.Forms.Label labelUsername;
      private System.Windows.Forms.Label labelPassword;
   }
}