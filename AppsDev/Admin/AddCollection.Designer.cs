
namespace AppsDev.Admin
{
   partial class AddCollection
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
         this.lblDate = new System.Windows.Forms.Label();
         this.txtFirstName = new System.Windows.Forms.TextBox();
         this.label1111 = new System.Windows.Forms.Label();
         this.txtID = new System.Windows.Forms.TextBox();
         this.label = new System.Windows.Forms.Label();
         this.btnCollect = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.cmbEvents = new System.Windows.Forms.ComboBox();
         this.txtLastName = new System.Windows.Forms.TextBox();
         this.txtEventID = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lblDate
         // 
         this.lblDate.AutoSize = true;
         this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDate.Location = new System.Drawing.Point(182, 237);
         this.lblDate.Name = "lblDate";
         this.lblDate.Size = new System.Drawing.Size(58, 13);
         this.lblDate.TabIndex = 97;
         this.lblDate.Text = "Last Name";
         // 
         // txtFirstName
         // 
         this.txtFirstName.Enabled = false;
         this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtFirstName.Location = new System.Drawing.Point(249, 193);
         this.txtFirstName.Multiline = true;
         this.txtFirstName.Name = "txtFirstName";
         this.txtFirstName.Size = new System.Drawing.Size(152, 20);
         this.txtFirstName.TabIndex = 96;
         // 
         // label1111
         // 
         this.label1111.AutoSize = true;
         this.label1111.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1111.Location = new System.Drawing.Point(182, 196);
         this.label1111.Name = "label1111";
         this.label1111.Size = new System.Drawing.Size(57, 13);
         this.label1111.TabIndex = 95;
         this.label1111.Text = "First Name";
         // 
         // txtID
         // 
         this.txtID.Enabled = false;
         this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtID.Location = new System.Drawing.Point(249, 159);
         this.txtID.Multiline = true;
         this.txtID.Name = "txtID";
         this.txtID.Size = new System.Drawing.Size(152, 20);
         this.txtID.TabIndex = 94;
         // 
         // label
         // 
         this.label.AutoSize = true;
         this.label.Enabled = false;
         this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label.Location = new System.Drawing.Point(182, 159);
         this.label.Name = "label";
         this.label.Size = new System.Drawing.Size(43, 13);
         this.label.TabIndex = 93;
         this.label.Text = "User ID";
         // 
         // btnCollect
         // 
         this.btnCollect.Location = new System.Drawing.Point(285, 370);
         this.btnCollect.Name = "btnCollect";
         this.btnCollect.Size = new System.Drawing.Size(64, 36);
         this.btnCollect.TabIndex = 100;
         this.btnCollect.Text = "Collect";
         this.btnCollect.UseVisualStyleBackColor = true;
         this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(178, 72);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(256, 42);
         this.label1.TabIndex = 101;
         this.label1.Text = "COLLECTION";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(182, 274);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(40, 13);
         this.label2.TabIndex = 102;
         this.label2.Text = "Events";
         // 
         // cmbEvents
         // 
         this.cmbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbEvents.FormattingEnabled = true;
         this.cmbEvents.Location = new System.Drawing.Point(249, 274);
         this.cmbEvents.Name = "cmbEvents";
         this.cmbEvents.Size = new System.Drawing.Size(152, 21);
         this.cmbEvents.TabIndex = 103;
         this.cmbEvents.SelectedIndexChanged += new System.EventHandler(this.cmbEvents_SelectedIndexChanged);
         // 
         // txtLastName
         // 
         this.txtLastName.Enabled = false;
         this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtLastName.Location = new System.Drawing.Point(249, 237);
         this.txtLastName.Multiline = true;
         this.txtLastName.Name = "txtLastName";
         this.txtLastName.Size = new System.Drawing.Size(152, 20);
         this.txtLastName.TabIndex = 104;
         // 
         // txtEventID
         // 
         this.txtEventID.Enabled = false;
         this.txtEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEventID.Location = new System.Drawing.Point(249, 313);
         this.txtEventID.Multiline = true;
         this.txtEventID.Name = "txtEventID";
         this.txtEventID.Size = new System.Drawing.Size(152, 20);
         this.txtEventID.TabIndex = 105;
         this.txtEventID.Visible = false;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(182, 320);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(52, 13);
         this.label3.TabIndex = 106;
         this.label3.Text = "Event  ID";
         this.label3.Visible = false;
         // 
         // AddCollection
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(582, 450);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtEventID);
         this.Controls.Add(this.txtLastName);
         this.Controls.Add(this.cmbEvents);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnCollect);
         this.Controls.Add(this.lblDate);
         this.Controls.Add(this.txtFirstName);
         this.Controls.Add(this.label1111);
         this.Controls.Add(this.txtID);
         this.Controls.Add(this.label);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "AddCollection";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AdminCollectionForm";
         this.Load += new System.EventHandler(this.AddCollection_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label lblDate;
      private System.Windows.Forms.TextBox txtFirstName;
      private System.Windows.Forms.Label label1111;
      private System.Windows.Forms.TextBox txtID;
      private System.Windows.Forms.Label label;
      private System.Windows.Forms.Button btnCollect;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox cmbEvents;
      private System.Windows.Forms.TextBox txtLastName;
      private System.Windows.Forms.TextBox txtEventID;
      private System.Windows.Forms.Label label3;
   }
}