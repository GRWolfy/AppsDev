
namespace AppsDev
{
   partial class Test
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
         this.txt1 = new System.Windows.Forms.TextBox();
         this.txt2 = new System.Windows.Forms.MaskedTextBox();
         this.txt3 = new System.Windows.Forms.MaskedTextBox();
         this.rbtnMale = new System.Windows.Forms.RadioButton();
         this.rbtnFemale = new System.Windows.Forms.RadioButton();
         this.comboBoxStatus = new System.Windows.Forms.ComboBox();
         this.button1 = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // txt1
         // 
         this.txt1.Location = new System.Drawing.Point(419, 107);
         this.txt1.Name = "txt1";
         this.txt1.Size = new System.Drawing.Size(100, 20);
         this.txt1.TabIndex = 0;
         this.txt1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt1_KeyUp);
         // 
         // txt2
         // 
         this.txt2.Location = new System.Drawing.Point(419, 146);
         this.txt2.Name = "txt2";
         this.txt2.Size = new System.Drawing.Size(100, 20);
         this.txt2.TabIndex = 1;
         this.txt2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt2_KeyUp);
         // 
         // txt3
         // 
         this.txt3.Location = new System.Drawing.Point(419, 181);
         this.txt3.Name = "txt3";
         this.txt3.Size = new System.Drawing.Size(100, 20);
         this.txt3.TabIndex = 2;
         this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
         // 
         // rbtnMale
         // 
         this.rbtnMale.AutoSize = true;
         this.rbtnMale.Location = new System.Drawing.Point(419, 218);
         this.rbtnMale.Name = "rbtnMale";
         this.rbtnMale.Size = new System.Drawing.Size(48, 17);
         this.rbtnMale.TabIndex = 3;
         this.rbtnMale.TabStop = true;
         this.rbtnMale.Text = "Male";
         this.rbtnMale.UseVisualStyleBackColor = true;
         // 
         // rbtnFemale
         // 
         this.rbtnFemale.AutoSize = true;
         this.rbtnFemale.Location = new System.Drawing.Point(483, 218);
         this.rbtnFemale.Name = "rbtnFemale";
         this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
         this.rbtnFemale.TabIndex = 4;
         this.rbtnFemale.TabStop = true;
         this.rbtnFemale.Text = "Female";
         this.rbtnFemale.UseVisualStyleBackColor = true;
         // 
         // comboBoxStatus
         // 
         this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBoxStatus.FormattingEnabled = true;
         this.comboBoxStatus.Items.AddRange(new object[] {
            "Single",
            "Married"});
         this.comboBoxStatus.Location = new System.Drawing.Point(419, 256);
         this.comboBoxStatus.Name = "comboBoxStatus";
         this.comboBoxStatus.Size = new System.Drawing.Size(123, 21);
         this.comboBoxStatus.TabIndex = 5;
         this.comboBoxStatus.SelectedValueChanged += new System.EventHandler(this.comboBoxStatus_SelectedValueChanged);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(419, 308);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(106, 43);
         this.button1.TabIndex = 6;
         this.button1.Text = "button1";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(525, 114);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 7;
         this.label1.Text = "label1";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(525, 153);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(35, 13);
         this.label2.TabIndex = 8;
         this.label2.Text = "label2";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(525, 188);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(35, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "label3";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(548, 222);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(35, 13);
         this.label4.TabIndex = 10;
         this.label4.Text = "label4";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(548, 264);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(35, 13);
         this.label5.TabIndex = 11;
         this.label5.Text = "label5";
         // 
         // Test
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.comboBoxStatus);
         this.Controls.Add(this.rbtnFemale);
         this.Controls.Add(this.rbtnMale);
         this.Controls.Add(this.txt3);
         this.Controls.Add(this.txt2);
         this.Controls.Add(this.txt1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "Test";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Test";
         this.Load += new System.EventHandler(this.Test_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txt1;
      private System.Windows.Forms.MaskedTextBox txt2;
      private System.Windows.Forms.MaskedTextBox txt3;
      private System.Windows.Forms.RadioButton rbtnMale;
      private System.Windows.Forms.RadioButton rbtnFemale;
      private System.Windows.Forms.ComboBox comboBoxStatus;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
   }
}