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
   public partial class Home : Form
   {
      public Home()
      {
         InitializeComponent();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         Hide();
      }

      private void linklRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var register = new Register();
         register.Show();
         Hide();
      }

      private void btnTest_Click(object sender, EventArgs e)
      {
         var test = new Test();
         test.Show();
         Hide();
      }
   }
}
