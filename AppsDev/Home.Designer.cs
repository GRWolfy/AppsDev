
namespace AppsDev
{
   partial class Home
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
         this.btnLogin = new System.Windows.Forms.Button();
         this.btnClose = new System.Windows.Forms.Button();
         this.linklRegister = new System.Windows.Forms.LinkLabel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.SuspendLayout();
         // 
         // btnLogin
         // 
         this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLogin.Location = new System.Drawing.Point(598, 391);
         this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(219, 89);
         this.btnLogin.TabIndex = 0;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // btnClose
         // 
         this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.Location = new System.Drawing.Point(910, 391);
         this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(219, 89);
         this.btnClose.TabIndex = 1;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // linklRegister
         // 
         this.linklRegister.AutoSize = true;
         this.linklRegister.Location = new System.Drawing.Point(716, 525);
         this.linklRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.linklRegister.Name = "linklRegister";
         this.linklRegister.Size = new System.Drawing.Size(287, 20);
         this.linklRegister.TabIndex = 2;
         this.linklRegister.TabStop = true;
         this.linklRegister.Text = "Need an account? Click here to register";
         this.linklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRegister_LinkClicked);
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
         this.panel1.Location = new System.Drawing.Point(0, 2);
         this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(516, 697);
         this.panel1.TabIndex = 3;
         // 
         // Home
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 692);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.linklRegister);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnLogin);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Home";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Home";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.LinkLabel linklRegister;
      private System.Windows.Forms.Panel panel1;
   }
}

