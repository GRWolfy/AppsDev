
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
         this.SuspendLayout();
         // 
         // btnLogin
         // 
         this.btnLogin.Location = new System.Drawing.Point(179, 279);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(146, 58);
         this.btnLogin.TabIndex = 0;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // btnClose
         // 
         this.btnClose.Location = new System.Drawing.Point(454, 279);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(146, 58);
         this.btnClose.TabIndex = 1;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // linklRegister
         // 
         this.linklRegister.AutoSize = true;
         this.linklRegister.Location = new System.Drawing.Point(211, 366);
         this.linklRegister.Name = "linklRegister";
         this.linklRegister.Size = new System.Drawing.Size(103, 13);
         this.linklRegister.TabIndex = 2;
         this.linklRegister.TabStop = true;
         this.linklRegister.Text = "Click here to register";
         this.linklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRegister_LinkClicked);
         // 
         // Home
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.linklRegister);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnLogin);
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
   }
}

