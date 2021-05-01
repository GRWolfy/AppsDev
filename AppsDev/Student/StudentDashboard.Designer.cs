
namespace AppsDev.Student
{
   partial class StudentDashboard
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
         this.lblFirstname = new System.Windows.Forms.Label();
         this.lblLastname = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(43, 24);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(301, 39);
         this.label1.TabIndex = 0;
         this.label1.Text = "Welcome Student!";
         // 
         // lblFirstname
         // 
         this.lblFirstname.AutoSize = true;
         this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFirstname.Location = new System.Drawing.Point(96, 110);
         this.lblFirstname.Name = "lblFirstname";
         this.lblFirstname.Size = new System.Drawing.Size(70, 25);
         this.lblFirstname.TabIndex = 1;
         this.lblFirstname.Text = "label2";
         // 
         // lblLastname
         // 
         this.lblLastname.AutoSize = true;
         this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblLastname.Location = new System.Drawing.Point(227, 110);
         this.lblLastname.Name = "lblLastname";
         this.lblLastname.Size = new System.Drawing.Size(70, 25);
         this.lblLastname.TabIndex = 2;
         this.lblLastname.Text = "label3";
         // 
         // StudentDashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.lblLastname);
         this.Controls.Add(this.lblFirstname);
         this.Controls.Add(this.label1);
         this.Name = "StudentDashboard";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "StudentDashboard";
         this.Load += new System.EventHandler(this.StudentDashboard_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblFirstname;
      private System.Windows.Forms.Label lblLastname;
   }
}