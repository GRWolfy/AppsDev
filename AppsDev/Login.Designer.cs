
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
         this.components = new System.ComponentModel.Container();
         this.btnLoginAccount = new System.Windows.Forms.Button();
         this.linklRegister = new System.Windows.Forms.LinkLabel();
         this.txtUsername = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.lblUsername = new System.Windows.Forms.Label();
         this.lvlPassword = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.tooltipPaimon = new System.Windows.Forms.ToolTip(this.components);
         this.tooltipAngry = new System.Windows.Forms.ToolTip(this.components);
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // btnLoginAccount
         // 
         this.btnLoginAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLoginAccount.Location = new System.Drawing.Point(885, 485);
         this.btnLoginAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnLoginAccount.Name = "btnLoginAccount";
         this.btnLoginAccount.Size = new System.Drawing.Size(166, 71);
         this.btnLoginAccount.TabIndex = 0;
         this.btnLoginAccount.Text = "Login";
         this.btnLoginAccount.UseVisualStyleBackColor = true;
         this.btnLoginAccount.Click += new System.EventHandler(this.btnLoginAccount_Click);
         // 
         // linklRegister
         // 
         this.linklRegister.AutoSize = true;
         this.linklRegister.Location = new System.Drawing.Point(632, 485);
         this.linklRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.linklRegister.Name = "linklRegister";
         this.linklRegister.Size = new System.Drawing.Size(153, 20);
         this.linklRegister.TabIndex = 1;
         this.linklRegister.TabStop = true;
         this.linklRegister.Text = "Click here to register";
         this.linklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRegister_LinkClicked);
         // 
         // txtUsername
         // 
         this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtUsername.Location = new System.Drawing.Point(826, 228);
         this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(223, 26);
         this.txtUsername.TabIndex = 2;
         // 
         // txtPassword
         // 
         this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPassword.Location = new System.Drawing.Point(826, 314);
         this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '•';
         this.txtPassword.Size = new System.Drawing.Size(223, 26);
         this.txtPassword.TabIndex = 3;
         this.txtPassword.UseSystemPasswordChar = true;
         // 
         // lblUsername
         // 
         this.lblUsername.AutoSize = true;
         this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblUsername.Location = new System.Drawing.Point(672, 225);
         this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblUsername.Name = "lblUsername";
         this.lblUsername.Size = new System.Drawing.Size(87, 20);
         this.lblUsername.TabIndex = 4;
         this.lblUsername.Text = "Username:";
         // 
         // lvlPassword
         // 
         this.lvlPassword.AutoSize = true;
         this.lvlPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lvlPassword.Location = new System.Drawing.Point(676, 314);
         this.lvlPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lvlPassword.Name = "lvlPassword";
         this.lvlPassword.Size = new System.Drawing.Size(82, 20);
         this.lvlPassword.TabIndex = 5;
         this.lvlPassword.Text = "Password:";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
         this.panel1.Controls.Add(this.pictureBox2);
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Location = new System.Drawing.Point(0, 3);
         this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(516, 697);
         this.panel1.TabIndex = 6;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Image = global::AppsDev.Properties.Resources.AngryPaimon;
         this.pictureBox2.Location = new System.Drawing.Point(66, 372);
         this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(238, 265);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox2.TabIndex = 1;
         this.pictureBox2.TabStop = false;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::AppsDev.Properties.Resources.Paimon;
         this.pictureBox1.Location = new System.Drawing.Point(66, 372);
         this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(238, 265);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
         // 
         // tooltipPaimon
         // 
         this.tooltipPaimon.IsBalloon = true;
         // 
         // tooltipAngry
         // 
         this.tooltipAngry.IsBalloon = true;
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 692);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.lvlPassword);
         this.Controls.Add(this.lblUsername);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.linklRegister);
         this.Controls.Add(this.btnLoginAccount);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Login";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.Load += new System.EventHandler(this.Login_Load);
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.ToolTip tooltipPaimon;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.ToolTip tooltipAngry;
   }
}