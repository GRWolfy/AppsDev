
namespace AppsDev.Student
{
   partial class StudentProfile
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
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnLogout = new System.Windows.Forms.Button();
         this.btnProfile = new System.Windows.Forms.Button();
         this.btnViewPayments = new System.Windows.Forms.Button();
         this.btnDashboard = new System.Windows.Forms.Button();
         this.labelLastname = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.labelFirstname = new System.Windows.Forms.Label();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(321, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(285, 37);
         this.label1.TabIndex = 1;
         this.label1.Text = "Welcome Students";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
         this.panel1.Controls.Add(this.btnLogout);
         this.panel1.Controls.Add(this.btnProfile);
         this.panel1.Controls.Add(this.btnViewPayments);
         this.panel1.Controls.Add(this.btnDashboard);
         this.panel1.Controls.Add(this.labelLastname);
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Controls.Add(this.labelFirstname);
         this.panel1.Location = new System.Drawing.Point(2, 1);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(182, 437);
         this.panel1.TabIndex = 2;
         // 
         // btnLogout
         // 
         this.btnLogout.Location = new System.Drawing.Point(24, 309);
         this.btnLogout.Name = "btnLogout";
         this.btnLogout.Size = new System.Drawing.Size(134, 28);
         this.btnLogout.TabIndex = 10;
         this.btnLogout.Text = "Logout";
         this.btnLogout.UseVisualStyleBackColor = true;
         // 
         // btnProfile
         // 
         this.btnProfile.Location = new System.Drawing.Point(24, 265);
         this.btnProfile.Name = "btnProfile";
         this.btnProfile.Size = new System.Drawing.Size(134, 28);
         this.btnProfile.TabIndex = 7;
         this.btnProfile.Text = "Profile";
         this.btnProfile.UseVisualStyleBackColor = true;
         // 
         // btnViewPayments
         // 
         this.btnViewPayments.Location = new System.Drawing.Point(24, 222);
         this.btnViewPayments.Name = "btnViewPayments";
         this.btnViewPayments.Size = new System.Drawing.Size(134, 28);
         this.btnViewPayments.TabIndex = 6;
         this.btnViewPayments.Text = "View Payments";
         this.btnViewPayments.UseVisualStyleBackColor = true;
         // 
         // btnDashboard
         // 
         this.btnDashboard.Location = new System.Drawing.Point(24, 179);
         this.btnDashboard.Name = "btnDashboard";
         this.btnDashboard.Size = new System.Drawing.Size(134, 28);
         this.btnDashboard.TabIndex = 3;
         this.btnDashboard.Text = "Dashboard";
         this.btnDashboard.UseVisualStyleBackColor = true;
         // 
         // labelLastname
         // 
         this.labelLastname.AutoSize = true;
         this.labelLastname.Location = new System.Drawing.Point(102, 145);
         this.labelLastname.Name = "labelLastname";
         this.labelLastname.Size = new System.Drawing.Size(35, 13);
         this.labelLastname.TabIndex = 5;
         this.labelLastname.Text = "label3";
         // 
         // pictureBox1
         // 
         this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox1.Image = global::AppsDev.Properties.Resources.WolfAvatar;
         this.pictureBox1.Location = new System.Drawing.Point(24, 11);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(134, 113);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // labelFirstname
         // 
         this.labelFirstname.AutoSize = true;
         this.labelFirstname.Location = new System.Drawing.Point(37, 145);
         this.labelFirstname.Name = "labelFirstname";
         this.labelFirstname.Size = new System.Drawing.Size(35, 13);
         this.labelFirstname.TabIndex = 3;
         this.labelFirstname.Text = "label2";
         // 
         // StudentProfile
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 435);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.Name = "StudentProfile";
         this.Text = "StudentProfile";
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label labelLastname;
      private System.Windows.Forms.Label labelFirstname;
      private System.Windows.Forms.Button btnProfile;
      private System.Windows.Forms.Button btnViewPayments;
      private System.Windows.Forms.Button btnDashboard;
      private System.Windows.Forms.Button btnLogout;
   }
}