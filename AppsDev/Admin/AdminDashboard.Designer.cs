
namespace AppsDev.Admin
{
   partial class AdminDashboard
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
         this.panel2 = new System.Windows.Forms.Panel();
         this.lblTotalRegistration = new System.Windows.Forms.Label();
         this.panel3 = new System.Windows.Forms.Panel();
         this.lblTotalCollection = new System.Windows.Forms.Label();
         this.panel4 = new System.Windows.Forms.Panel();
         this.lblTotalEvents = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.linklViewRegistration = new System.Windows.Forms.LinkLabel();
         this.linklViewEvents = new System.Windows.Forms.LinkLabel();
         this.linklViewCollection = new System.Windows.Forms.LinkLabel();
         this.label7 = new System.Windows.Forms.Label();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.panel2.SuspendLayout();
         this.panel3.SuspendLayout();
         this.panel4.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(482, 18);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
         this.panel1.Location = new System.Drawing.Point(3, 2);
         this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(273, 672);
         this.panel1.TabIndex = 2;
         this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
         // 
         // btnLogout
         // 
         this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLogout.Location = new System.Drawing.Point(36, 606);
         this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnLogout.Name = "btnLogout";
         this.btnLogout.Size = new System.Drawing.Size(201, 43);
         this.btnLogout.TabIndex = 10;
         this.btnLogout.Text = "Logout";
         this.btnLogout.UseVisualStyleBackColor = true;
         this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
         // 
         // btnReports
         // 
         this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnReports.Location = new System.Drawing.Point(36, 540);
         this.btnReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnReports.Name = "btnReports";
         this.btnReports.Size = new System.Drawing.Size(201, 43);
         this.btnReports.TabIndex = 9;
         this.btnReports.Text = "Reports";
         this.btnReports.UseVisualStyleBackColor = true;
         this.btnReports.Click += new System.EventHandler(this.button5_Click);
         // 
         // btnCollection
         // 
         this.btnCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCollection.Location = new System.Drawing.Point(36, 474);
         this.btnCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnCollection.Name = "btnCollection";
         this.btnCollection.Size = new System.Drawing.Size(201, 43);
         this.btnCollection.TabIndex = 8;
         this.btnCollection.Text = "Collection";
         this.btnCollection.UseVisualStyleBackColor = true;
         this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
         // 
         // btnEvents
         // 
         this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnEvents.Location = new System.Drawing.Point(36, 408);
         this.btnEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnEvents.Name = "btnEvents";
         this.btnEvents.Size = new System.Drawing.Size(201, 43);
         this.btnEvents.TabIndex = 7;
         this.btnEvents.Text = "Events";
         this.btnEvents.UseVisualStyleBackColor = true;
         this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
         // 
         // btnRegistration
         // 
         this.btnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRegistration.Location = new System.Drawing.Point(36, 342);
         this.btnRegistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnRegistration.Name = "btnRegistration";
         this.btnRegistration.Size = new System.Drawing.Size(201, 43);
         this.btnRegistration.TabIndex = 6;
         this.btnRegistration.Text = "Registration";
         this.btnRegistration.UseVisualStyleBackColor = true;
         this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
         // 
         // btnDashboard
         // 
         this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDashboard.Location = new System.Drawing.Point(36, 275);
         this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnDashboard.Name = "btnDashboard";
         this.btnDashboard.Size = new System.Drawing.Size(201, 43);
         this.btnDashboard.TabIndex = 3;
         this.btnDashboard.Text = "Dashboard";
         this.btnDashboard.UseVisualStyleBackColor = true;
         this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
         // 
         // labelLastname
         // 
         this.labelLastname.AutoSize = true;
         this.labelLastname.Location = new System.Drawing.Point(153, 223);
         this.labelLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.labelLastname.Name = "labelLastname";
         this.labelLastname.Size = new System.Drawing.Size(86, 20);
         this.labelLastname.TabIndex = 5;
         this.labelLastname.Text = "Last Name";
         // 
         // pictureBox1
         // 
         this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox1.Image = global::AppsDev.Properties.Resources.WolfAvatar;
         this.pictureBox1.Location = new System.Drawing.Point(36, 17);
         this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(199, 172);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // labelFirstname
         // 
         this.labelFirstname.AutoSize = true;
         this.labelFirstname.Location = new System.Drawing.Point(56, 223);
         this.labelFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.labelFirstname.Name = "labelFirstname";
         this.labelFirstname.Size = new System.Drawing.Size(86, 20);
         this.labelFirstname.TabIndex = 3;
         this.labelFirstname.Text = "First Name";
         // 
         // panel2
         // 
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel2.Controls.Add(this.lblTotalRegistration);
         this.panel2.Location = new System.Drawing.Point(300, 189);
         this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(253, 229);
         this.panel2.TabIndex = 3;
         // 
         // lblTotalRegistration
         // 
         this.lblTotalRegistration.AutoSize = true;
         this.lblTotalRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalRegistration.Location = new System.Drawing.Point(39, 55);
         this.lblTotalRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblTotalRegistration.Name = "lblTotalRegistration";
         this.lblTotalRegistration.Size = new System.Drawing.Size(68, 73);
         this.lblTotalRegistration.TabIndex = 5;
         this.lblTotalRegistration.Text = "0";
         // 
         // panel3
         // 
         this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel3.Controls.Add(this.lblTotalCollection);
         this.panel3.Location = new System.Drawing.Point(603, 189);
         this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(253, 229);
         this.panel3.TabIndex = 4;
         // 
         // lblTotalCollection
         // 
         this.lblTotalCollection.AutoSize = true;
         this.lblTotalCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalCollection.Location = new System.Drawing.Point(52, 85);
         this.lblTotalCollection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblTotalCollection.Name = "lblTotalCollection";
         this.lblTotalCollection.Size = new System.Drawing.Size(39, 42);
         this.lblTotalCollection.TabIndex = 6;
         this.lblTotalCollection.Text = "0";
         // 
         // panel4
         // 
         this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel4.Controls.Add(this.lblTotalEvents);
         this.panel4.Location = new System.Drawing.Point(904, 189);
         this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(253, 229);
         this.panel4.TabIndex = 4;
         // 
         // lblTotalEvents
         // 
         this.lblTotalEvents.AutoSize = true;
         this.lblTotalEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalEvents.Location = new System.Drawing.Point(39, 55);
         this.lblTotalEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblTotalEvents.Name = "lblTotalEvents";
         this.lblTotalEvents.Size = new System.Drawing.Size(68, 73);
         this.lblTotalEvents.TabIndex = 7;
         this.lblTotalEvents.Text = "0";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(334, 454);
         this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(124, 18);
         this.label5.TabIndex = 6;
         this.label5.Text = "Total Registration";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(938, 454);
         this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(90, 18);
         this.label4.TabIndex = 7;
         this.label4.Text = "Total Events";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(633, 454);
         this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(111, 18);
         this.label6.TabIndex = 8;
         this.label6.Text = "Total Collection";
         // 
         // linklViewRegistration
         // 
         this.linklViewRegistration.AutoSize = true;
         this.linklViewRegistration.Location = new System.Drawing.Point(350, 542);
         this.linklViewRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.linklViewRegistration.Name = "linklViewRegistration";
         this.linklViewRegistration.Size = new System.Drawing.Size(134, 20);
         this.linklViewRegistration.TabIndex = 9;
         this.linklViewRegistration.TabStop = true;
         this.linklViewRegistration.Text = "Total Registration";
         this.linklViewRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklViewRegistration_LinkClicked);
         // 
         // linklViewEvents
         // 
         this.linklViewEvents.AutoSize = true;
         this.linklViewEvents.Location = new System.Drawing.Point(944, 542);
         this.linklViewEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.linklViewEvents.Name = "linklViewEvents";
         this.linklViewEvents.Size = new System.Drawing.Size(97, 20);
         this.linklViewEvents.TabIndex = 10;
         this.linklViewEvents.TabStop = true;
         this.linklViewEvents.Text = "Total Events";
         this.linklViewEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklViewEvents_LinkClicked);
         // 
         // linklViewCollection
         // 
         this.linklViewCollection.AutoSize = true;
         this.linklViewCollection.Location = new System.Drawing.Point(651, 542);
         this.linklViewCollection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.linklViewCollection.Name = "linklViewCollection";
         this.linklViewCollection.Size = new System.Drawing.Size(117, 20);
         this.linklViewCollection.TabIndex = 11;
         this.linklViewCollection.TabStop = true;
         this.linklViewCollection.Text = "Total Collection";
         this.linklViewCollection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklViewCollection_LinkClicked);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(315, 108);
         this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(117, 25);
         this.label7.TabIndex = 12;
         this.label7.Text = "Dashboard";
         // 
         // AdminDashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 692);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.linklViewCollection);
         this.Controls.Add(this.linklViewEvents);
         this.Controls.Add(this.linklViewRegistration);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.panel4);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.DoubleBuffered = true;
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.Name = "AdminDashboard";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AdminDashboard";
         this.Load += new System.EventHandler(this.AdminDashboard_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         this.panel4.ResumeLayout(false);
         this.panel4.PerformLayout();
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
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label lblTotalRegistration;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Label lblTotalCollection;
      private System.Windows.Forms.Panel panel4;
      private System.Windows.Forms.Label lblTotalEvents;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.LinkLabel linklViewRegistration;
      private System.Windows.Forms.LinkLabel linklViewEvents;
      private System.Windows.Forms.LinkLabel linklViewCollection;
      private System.Windows.Forms.Label label7;
   }
}