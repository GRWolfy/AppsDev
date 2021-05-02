using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDev
{
   public partial class Test : Form
   {
      private bool[] EachCheck = new bool[5];
      private bool checker = false;
      public Test()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {

         if (rbtnMale.Checked)
         {
            rbtnFemale.Checked = false;
            EachCheck[3] = true;
            label4.Text = EachCheck[3].ToString();
         }
         else if (rbtnFemale.Checked)
         {
            rbtnMale.Checked = false;
            EachCheck[3] = false;
            label4.Text = EachCheck[3].ToString();
         }

         for (int i = 0; i < EachCheck.Length; i++)
         {
            if (EachCheck[i] == false)
            {
               MessageBox.Show("MISSING FIELD");
               break;
            }
            else if (EachCheck[i] == true && i == EachCheck.Length-1)
            {
               var login = new Login();
               login.Show();
               Hide();
            }
         }
      }

      private void Test_Load(object sender, EventArgs e)
      {
         for (int i = 0; i < EachCheck.Length; i++)
         {
            EachCheck[i] = false;
         }
      }

      private void txt1_KeyUp(object sender, KeyEventArgs e)
      {
         //simulating my username;
         string CONST_INPUT = "wolf";
         bool check = txt1.Text.Equals(CONST_INPUT) ? true : false;

         if (check)
         {
            EachCheck[0] = true;
            label1.Text = EachCheck[0].ToString();
         }
         else
         {
            EachCheck[0] = false;
            label1.Text = EachCheck[0].ToString();
         }
      }

      private void txt2_KeyUp(object sender, KeyEventArgs e)
      {
         //simulate my password
         string CONST_INPUT = "wolf";
         bool check = txt2.Text.Equals(CONST_INPUT) ? true : false;

         if (check)
         {
            EachCheck[1] = true;
            label2.Text = EachCheck[1].ToString();
         }
         else
         {
            EachCheck[1] = false;
            label2.Text = EachCheck[1].ToString();
         }
      }

      private void txt3_KeyPress(object sender, KeyPressEventArgs e)
      {
         //simulate firstname and lastname
         if (txt3.Text == "")
         {
            EachCheck[2] = false;
            label3.Text = EachCheck[2].ToString();
         }
         else
         {
            EachCheck[2] = true;
            label3.Text = EachCheck[2].ToString();
         }
      }

      private void comboBoxStatus_SelectedValueChanged(object sender, EventArgs e)
      {
         EachCheck[4] = true;  
      }
   }
}
