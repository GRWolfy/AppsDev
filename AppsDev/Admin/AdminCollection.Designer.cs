
namespace AppsDev.Admin
{
   partial class AdminCollection
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
         this.btnReports = new System.Windows.Forms.Button();
         this.btnCollection = new System.Windows.Forms.Button();
         this.btnEvents = new System.Windows.Forms.Button();
         this.btnRegistration = new System.Windows.Forms.Button();
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
         this.label1.Size = new System.Drawing.Size(251, 37);
         this.label1.TabIndex = 1;
         this.label1.Text = "Welcome Admin";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
         this.panel1.Controls.Add(this.btnLogout);
         this.panel1.Controls.Add(this.btnReports);
         this.panel1.Controls.Add(this.btnCollection);
         this.panel1.Controls.Add(this.btnEvents);
         this.panel1.Controls.Add(this.btnRegistration);
         this.panel1.Controls.Add(this.btnDashboard);
         this.panel1.Controls.Add(this.labelLastname);
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Controls.Add(this.labelFirstname);
         this.panel1.Location = new System.Drawing.Point(2, 1);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(182, 437);
         this.panel1.TabIndex = 2;
         this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
         // 
         // btnLogout
         // 
         this.btnLogout.Location = new System.Drawing.Point(24, 394);
         this.btnLogout.Name = "btnLogout";
         this.btnLogout.Size = new System.Drawing.Size(134, 28);
         this.btnLogout.TabIndex = 10;
         this.btnLogout.Text = "Logout";
         this.btnLogout.UseVisualStyleBackColor = true;
         this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
         // 
         // btnReports
         // 
         this.btnReports.Location = new System.Drawing.Point(24, 351);
         this.btnReports.Name = "btnReports";
         this.btnReports.Size = new System.Drawing.Size(134, 28);
         this.btnReports.TabIndex = 9;
         this.btnReports.Text = "Reports";
         this.btnReports.UseVisualStyleBackColor = true;
         this.btnReports.Click += new System.EventHandler(this.button5_Click);
         // 
         // btnCollection
         // 
         this.btnCollection.Location = new System.Drawing.Point(24, 308);
         this.btnCollection.Name = "btnCollection";
         this.btnCollection.Size = new System.Drawing.Size(134, 28);
         this.btnCollection.TabIndex = 8;
         this.btnCollection.Text = "Collection";
         this.btnCollection.UseVisualStyleBackColor = true;
         this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
         // 
         // btnEvents
         // 
         this.btnEvents.Location = new System.Drawing.Point(24, 265);
         this.btnEvents.Name = "btnEvents";
         this.btnEvents.Size = new System.Drawing.Size(134, 28);
         this.btnEvents.TabIndex = 7;
         this.btnEvents.Text = "Events";
         this.btnEvents.UseVisualStyleBackColor = true;
         this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
         // 
         // btnRegistration
         // 
         this.btnRegistration.Location = new System.Drawing.Point(24, 222);
         this.btnRegistration.Name = "btnRegistration";
         this.btnRegistration.Size = new System.Drawing.Size(134, 28);
         this.btnRegistration.TabIndex = 6;
         this.btnRegistration.Text = "Registration";
         this.btnRegistration.UseVisualStyleBackColor = true;
         this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
         // 
         // btnDashboard
         // 
         this.btnDashboard.Location = new System.Drawing.Point(24, 179);
         this.btnDashboard.Name = "btnDashboard";
         this.btnDashboard.Size = new System.Drawing.Size(134, 28);
         this.btnDashboard.TabIndex = 3;
         this.btnDashboard.Text = "Dashboard";
         this.btnDashboard.UseVisualStyleBackColor = true;
         this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
         // 
         // labelLastname
         // 
         this.labelLastname.AutoSize = true;
         this.labelLastname.Location = new System.Drawing.Point(102, 145);
         this.labelLastname.Name = "labelLastname";
         this.labelLastname.Size = new System.Drawing.Size(58, 13);
         this.labelLastname.TabIndex = 5;
         this.labelLastname.Text = "Last Name";
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
         this.labelFirstname.Size = new System.Drawing.Size(57, 13);
         this.labelFirstname.TabIndex = 3;
         this.labelFirstname.Text = "First Name";
         // 
         // AdminCollection
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.MaximizeBox = false;
         this.Name = "AdminCollection";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AdminCollection";
         this.Load += new System.EventHandler(this.AdminDashboard_Load);
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
      private System.Windows.Forms.Button btnReports;
      private System.Windows.Forms.Button btnCollection;
      private System.Windows.Forms.Button btnEvents;
      private System.Windows.Forms.Button btnRegistration;
      private System.Windows.Forms.Button btnDashboard;
      private System.Windows.Forms.Button btnLogout;
   }
}