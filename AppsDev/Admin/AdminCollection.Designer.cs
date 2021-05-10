﻿
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
         this.label2 = new System.Windows.Forms.Label();
         this.tabControlCollection = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.txtEventid = new System.Windows.Forms.TextBox();
         this.DateTimePick = new System.Windows.Forms.DateTimePicker();
         this.lblDate = new System.Windows.Forms.Label();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.txtEventprice = new System.Windows.Forms.TextBox();
         this.label1111 = new System.Windows.Forms.Label();
         this.txtEventname = new System.Windows.Forms.TextBox();
         this.label = new System.Windows.Forms.Label();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.dataGridCollections = new System.Windows.Forms.DataGridView();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.tabControlCollection.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridCollections)).BeginInit();
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
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(210, 70);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(118, 25);
         this.label2.TabIndex = 4;
         this.label2.Text = "Collections";
         // 
         // tabControlCollection
         // 
         this.tabControlCollection.Controls.Add(this.tabPage1);
         this.tabControlCollection.Controls.Add(this.tabPage2);
         this.tabControlCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tabControlCollection.Location = new System.Drawing.Point(190, 116);
         this.tabControlCollection.Name = "tabControlCollection";
         this.tabControlCollection.SelectedIndex = 0;
         this.tabControlCollection.Size = new System.Drawing.Size(598, 307);
         this.tabControlCollection.TabIndex = 7;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.txtEventid);
         this.tabPage1.Controls.Add(this.DateTimePick);
         this.tabPage1.Controls.Add(this.lblDate);
         this.tabPage1.Controls.Add(this.btnDelete);
         this.tabPage1.Controls.Add(this.btnUpdate);
         this.tabPage1.Controls.Add(this.btnSave);
         this.tabPage1.Controls.Add(this.txtEventprice);
         this.tabPage1.Controls.Add(this.label1111);
         this.tabPage1.Controls.Add(this.txtEventname);
         this.tabPage1.Controls.Add(this.label);
         this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tabPage1.Location = new System.Drawing.Point(4, 29);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(590, 274);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Add | Update Collection";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // txtEventid
         // 
         this.txtEventid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEventid.Location = new System.Drawing.Point(237, 164);
         this.txtEventid.Multiline = true;
         this.txtEventid.Name = "txtEventid";
         this.txtEventid.Size = new System.Drawing.Size(152, 20);
         this.txtEventid.TabIndex = 92;
         this.txtEventid.Visible = false;
         // 
         // DateTimePick
         // 
         this.DateTimePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.DateTimePick.Location = new System.Drawing.Point(237, 123);
         this.DateTimePick.Name = "DateTimePick";
         this.DateTimePick.Size = new System.Drawing.Size(152, 20);
         this.DateTimePick.TabIndex = 91;
         this.DateTimePick.Visible = false;
         // 
         // lblDate
         // 
         this.lblDate.AutoSize = true;
         this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDate.Location = new System.Drawing.Point(190, 129);
         this.lblDate.Name = "lblDate";
         this.lblDate.Size = new System.Drawing.Size(33, 13);
         this.lblDate.TabIndex = 90;
         this.lblDate.Text = "Date:";
         this.lblDate.Visible = false;
         // 
         // btnDelete
         // 
         this.btnDelete.Enabled = false;
         this.btnDelete.Location = new System.Drawing.Point(314, 207);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(64, 36);
         this.btnDelete.TabIndex = 89;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         // 
         // btnUpdate
         // 
         this.btnUpdate.Enabled = false;
         this.btnUpdate.Location = new System.Drawing.Point(237, 207);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(64, 36);
         this.btnUpdate.TabIndex = 88;
         this.btnUpdate.Text = "Update";
         this.btnUpdate.UseVisualStyleBackColor = true;
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(160, 207);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(64, 36);
         this.btnSave.TabIndex = 87;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         // 
         // txtEventprice
         // 
         this.txtEventprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEventprice.Location = new System.Drawing.Point(237, 86);
         this.txtEventprice.Multiline = true;
         this.txtEventprice.Name = "txtEventprice";
         this.txtEventprice.Size = new System.Drawing.Size(152, 20);
         this.txtEventprice.TabIndex = 80;
         // 
         // label1111
         // 
         this.label1111.AutoSize = true;
         this.label1111.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1111.Location = new System.Drawing.Point(190, 86);
         this.label1111.Name = "label1111";
         this.label1111.Size = new System.Drawing.Size(34, 13);
         this.label1111.TabIndex = 75;
         this.label1111.Text = "Price:";
         // 
         // txtEventname
         // 
         this.txtEventname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEventname.Location = new System.Drawing.Point(237, 52);
         this.txtEventname.Multiline = true;
         this.txtEventname.Name = "txtEventname";
         this.txtEventname.Size = new System.Drawing.Size(152, 20);
         this.txtEventname.TabIndex = 65;
         // 
         // label
         // 
         this.label.AutoSize = true;
         this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label.Location = new System.Drawing.Point(170, 52);
         this.label.Name = "label";
         this.label.Size = new System.Drawing.Size(67, 13);
         this.label.TabIndex = 63;
         this.label.Text = "Event name:";
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.dataGridCollections);
         this.tabPage2.Location = new System.Drawing.Point(4, 29);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(590, 274);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "View Collection";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // dataGridCollections
         // 
         this.dataGridCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridCollections.Location = new System.Drawing.Point(2, 6);
         this.dataGridCollections.Name = "dataGridCollections";
         this.dataGridCollections.Size = new System.Drawing.Size(587, 267);
         this.dataGridCollections.TabIndex = 0;
         this.dataGridCollections.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCollections_CellMouseClick);
         // 
         // AdminCollection
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.tabControlCollection);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.MaximizeBox = false;
         this.Name = "AdminCollection";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AdminCollection";
         this.Load += new System.EventHandler(this.AdminCollection_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.tabControlCollection.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPage2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridCollections)).EndInit();
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
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TabControl tabControlCollection;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TextBox txtEventid;
      private System.Windows.Forms.DateTimePicker DateTimePick;
      private System.Windows.Forms.Label lblDate;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.TextBox txtEventprice;
      private System.Windows.Forms.Label label1111;
      private System.Windows.Forms.TextBox txtEventname;
      private System.Windows.Forms.Label label;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.DataGridView dataGridCollections;
   }
}