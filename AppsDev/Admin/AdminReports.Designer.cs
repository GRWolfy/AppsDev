
namespace AppsDev.Admin
{
   partial class AdminReports
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
         this.txtReportSubject = new System.Windows.Forms.TextBox();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.txtTotalSales = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.dataGridViewReports = new System.Windows.Forms.DataGridView();
         this.txtReportEncodedby = new System.Windows.Forms.TextBox();
         this.lblTotalSales = new System.Windows.Forms.Label();
         this.txtReportBody = new System.Windows.Forms.TextBox();
         this.txtReportId = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
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
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(315, 108);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(87, 25);
         this.label2.TabIndex = 3;
         this.label2.Text = "Reports";
         // 
         // txtReportSubject
         // 
         this.txtReportSubject.Location = new System.Drawing.Point(88, 34);
         this.txtReportSubject.Name = "txtReportSubject";
         this.txtReportSubject.Size = new System.Drawing.Size(294, 26);
         this.txtReportSubject.TabIndex = 5;
         // 
         // btnDelete
         // 
         this.btnDelete.Enabled = false;
         this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDelete.Location = new System.Drawing.Point(301, 393);
         this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(108, 55);
         this.btnDelete.TabIndex = 92;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnUpdate
         // 
         this.btnUpdate.Enabled = false;
         this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnUpdate.Location = new System.Drawing.Point(185, 393);
         this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(108, 55);
         this.btnUpdate.TabIndex = 91;
         this.btnUpdate.Text = "Update";
         this.btnUpdate.UseVisualStyleBackColor = true;
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // btnSave
         // 
         this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.Location = new System.Drawing.Point(69, 393);
         this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(108, 55);
         this.btnSave.TabIndex = 90;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Location = new System.Drawing.Point(335, 162);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(807, 512);
         this.tabControl1.TabIndex = 93;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.txtReportId);
         this.tabPage1.Controls.Add(this.txtReportBody);
         this.tabPage1.Controls.Add(this.lblTotalSales);
         this.tabPage1.Controls.Add(this.txtReportEncodedby);
         this.tabPage1.Controls.Add(this.label3);
         this.tabPage1.Controls.Add(this.txtTotalSales);
         this.tabPage1.Controls.Add(this.btnDelete);
         this.tabPage1.Controls.Add(this.txtReportSubject);
         this.tabPage1.Controls.Add(this.btnUpdate);
         this.tabPage1.Controls.Add(this.btnSave);
         this.tabPage1.Location = new System.Drawing.Point(4, 29);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(799, 479);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "ADD | UPDATE Report";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.dataGridViewReports);
         this.tabPage2.Location = new System.Drawing.Point(4, 29);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(799, 479);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "View Reports";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // txtTotalSales
         // 
         this.txtTotalSales.Enabled = false;
         this.txtTotalSales.Location = new System.Drawing.Point(521, 153);
         this.txtTotalSales.Name = "txtTotalSales";
         this.txtTotalSales.Size = new System.Drawing.Size(189, 26);
         this.txtTotalSales.TabIndex = 93;
         this.txtTotalSales.Visible = false;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(565, 56);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(88, 20);
         this.label3.TabIndex = 94;
         this.label3.Text = "Total Sales";
         // 
         // dataGridViewReports
         // 
         this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridViewReports.Location = new System.Drawing.Point(0, 3);
         this.dataGridViewReports.Name = "dataGridViewReports";
         this.dataGridViewReports.Size = new System.Drawing.Size(799, 473);
         this.dataGridViewReports.TabIndex = 0;
         this.dataGridViewReports.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewReports_CellMouseClick);
         // 
         // txtReportEncodedby
         // 
         this.txtReportEncodedby.Enabled = false;
         this.txtReportEncodedby.Location = new System.Drawing.Point(569, 209);
         this.txtReportEncodedby.Name = "txtReportEncodedby";
         this.txtReportEncodedby.Size = new System.Drawing.Size(100, 26);
         this.txtReportEncodedby.TabIndex = 95;
         this.txtReportEncodedby.Visible = false;
         // 
         // lblTotalSales
         // 
         this.lblTotalSales.AutoSize = true;
         this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalSales.Location = new System.Drawing.Point(575, 94);
         this.lblTotalSales.Name = "lblTotalSales";
         this.lblTotalSales.Size = new System.Drawing.Size(60, 24);
         this.lblTotalSales.TabIndex = 96;
         this.lblTotalSales.Text = "label4";
         // 
         // txtReportBody
         // 
         this.txtReportBody.Location = new System.Drawing.Point(88, 94);
         this.txtReportBody.Multiline = true;
         this.txtReportBody.Name = "txtReportBody";
         this.txtReportBody.Size = new System.Drawing.Size(294, 234);
         this.txtReportBody.TabIndex = 97;
         // 
         // txtReportId
         // 
         this.txtReportId.Location = new System.Drawing.Point(579, 271);
         this.txtReportId.Name = "txtReportId";
         this.txtReportId.Size = new System.Drawing.Size(100, 26);
         this.txtReportId.TabIndex = 98;
         this.txtReportId.Visible = false;
         // 
         // AdminReports
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 692);
         this.Controls.Add(this.tabControl1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.DoubleBuffered = true;
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.Name = "AdminReports";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Admin_Reports";
         this.Load += new System.EventHandler(this.AdminReports_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPage2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
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
      private System.Windows.Forms.TextBox txtReportSubject;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TextBox txtTotalSales;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.DataGridView dataGridViewReports;
      private System.Windows.Forms.TextBox txtReportEncodedby;
      private System.Windows.Forms.Label lblTotalSales;
      private System.Windows.Forms.TextBox txtReportBody;
      private System.Windows.Forms.TextBox txtReportId;
   }
}