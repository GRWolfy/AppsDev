
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
         this.lblUsername = new System.Windows.Forms.Label();
         this.lvlPassword = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // btnLoginAccount
         // 
         this.btnLoginAccount.Location = new System.Drawing.Point(577, 306);
         this.btnLoginAccount.Name = "btnLoginAccount";
         this.btnLoginAccount.Size = new System.Drawing.Size(105, 32);
         this.btnLoginAccount.TabIndex = 0;
         this.btnLoginAccount.Text = "Login";
         this.btnLoginAccount.UseVisualStyleBackColor = true;
         this.btnLoginAccount.Click += new System.EventHandler(this.btnLoginAccount_Click);
         // 
         // linklRegister
         // 
         this.linklRegister.AutoSize = true;
         this.linklRegister.Location = new System.Drawing.Point(421, 315);
         this.linklRegister.Name = "linklRegister";
         this.linklRegister.Size = new System.Drawing.Size(103, 13);
         this.linklRegister.TabIndex = 1;
         this.linklRegister.TabStop = true;
         this.linklRegister.Text = "Click here to register";
         this.linklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRegister_LinkClicked);
         // 
         // txtUsername
         // 
         this.txtUsername.Location = new System.Drawing.Point(550, 128);
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(149, 20);
         this.txtUsername.TabIndex = 2;
         // 
         // lblUsername
         // 
         this.lblUsername.AutoSize = true;
         this.lblUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblUsername.Location = new System.Drawing.Point(448, 132);
         this.lblUsername.Name = "lblUsername";
         this.lblUsername.Size = new System.Drawing.Size(76, 16);
         this.lblUsername.TabIndex = 4;
         this.lblUsername.Text = "Username:";
         // 
         // lvlPassword
         // 
         this.lvlPassword.AutoSize = true;
         this.lvlPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lvlPassword.Location = new System.Drawing.Point(451, 185);
         this.lvlPassword.Name = "lvlPassword";
         this.lvlPassword.Size = new System.Drawing.Size(73, 16);
         this.lvlPassword.TabIndex = 5;
         this.lvlPassword.Text = "Password:";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.DarkViolet;
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Location = new System.Drawing.Point(0, 2);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(344, 453);
         this.panel1.TabIndex = 6;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::AppsDev.Properties.Resources.Paimon;
         this.pictureBox1.Location = new System.Drawing.Point(126, 244);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(159, 172);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(550, 181);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(149, 20);
         this.txtPassword.TabIndex = 7;
         this.txtPassword.UseSystemPasswordChar = true;
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.lvlPassword);
         this.Controls.Add(this.lblUsername);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.linklRegister);
         this.Controls.Add(this.btnLoginAccount);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "Login";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.Load += new System.EventHandler(this.Login_Load);
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnLoginAccount;
      private System.Windows.Forms.LinkLabel linklRegister;
      private System.Windows.Forms.TextBox txtUsername;
      private System.Windows.Forms.Label lblUsername;
      private System.Windows.Forms.Label lvlPassword;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.TextBox txtPassword;
   }
}