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
   public partial class StudentDashboard : Form
   {
      public StudentDashboard()
      {
         InitializeComponent();
      }

      private void StudentDashboard_Load(object sender, EventArgs e)
      {
         lblFirstname.Text = Login.setfirstname;
         lblLastname.Text = Login.setlastname;
      }
   }
}
