using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDev.Student
{
   public partial class StudentViewPayments : Form
   {
      public StudentViewPayments()
      {
         InitializeComponent();
      }

      private void StudentViewPayments_Load(object sender, EventArgs e)
      {
         labelFirstname.Text = Login.setfirstname;
         labelLastname.Text = Login.setlastname;
         btnViewPayments.Enabled = false;
      }

      private void btnDashboard_Click(object sender, EventArgs e)
      {
         var studentdashboard = new StudentDashboard();
         studentdashboard.Show();
         Hide();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }
   }
}
