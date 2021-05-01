
namespace AppsDev
{
   partial class Login
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
         this.btnLoginAccount = new System.Windows.Forms.Button();
         this.linklRegister = new System.Windows.Forms.LinkLabel();
         this.txtUsername = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.lblUsername = new System.Windows.Forms.Label();
         this.lvlPassword = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnLoginAccount
         // 
         this.btnLoginAccount.Location = new System.Drawing.Point(363, 363);
         this.btnLoginAccount.Name = "btnLoginAccount";
         this.btnLoginAccount.Size = new System.Drawing.Size(75, 23);
         this.btnLoginAccount.TabIndex = 0;
         this.btnLoginAccount.Text = "Login";
         this.btnLoginAccount.UseVisualStyleBackColor = true;
         this.btnLoginAccount.Click += new System.EventHandler(this.btnLoginAccount_Click);
         // 
         // linklRegister
         // 
         this.linklRegister.AutoSize = true;
         this.linklRegister.Location = new System.Drawing.Point(207, 372);
         this.linklRegister.Name = "linklRegister";
         this.linklRegister.Size = new System.Drawing.Size(103, 13);
         this.linklRegister.TabIndex = 1;
         this.linklRegister.TabStop = true;
         this.linklRegister.Text = "Click here to register";
         this.linklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRegister_LinkClicked);
         // 
         // txtUsername
         // 
         this.txtUsername.Location = new System.Drawing.Point(337, 182);
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(100, 20);
         this.txtUsername.TabIndex = 2;
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(338, 254);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(100, 20);
         this.txtPassword.TabIndex = 3;
         this.txtPassword.UseSystemPasswordChar = true;
         // 
         // lblUsername
         // 
         this.lblUsername.AutoSize = true;
         this.lblUsername.Location = new System.Drawing.Point(207, 182);
         this.lblUsername.Name = "lblUsername";
         this.lblUsername.Size = new System.Drawing.Size(58, 13);
         this.lblUsername.TabIndex = 4;
         this.lblUsername.Text = "Username:";
         // 
         // lvlPassword
         // 
         this.lvlPassword.AutoSize = true;
         this.lvlPassword.Location = new System.Drawing.Point(207, 261);
         this.lvlPassword.Name = "lvlPassword";
         this.lvlPassword.Size = new System.Drawing.Size(56, 13);
         this.lvlPassword.TabIndex = 5;
         this.lvlPassword.Text = "Password:";
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.lvlPassword);
         this.Controls.Add(this.lblUsername);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.linklRegister);
         this.Controls.Add(this.btnLoginAccount);
         this.Name = "Login";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.Load += new System.EventHandler(this.Login_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnLoginAccount;
      private System.Windows.Forms.LinkLabel linklRegister;
      private System.Windows.Forms.TextBox txtUsername;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Label lblUsername;
      private System.Windows.Forms.Label lvlPassword;
   }
}