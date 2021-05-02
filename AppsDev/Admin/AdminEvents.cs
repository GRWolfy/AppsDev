using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppsDev.Admin
{
   public partial class AdminEvents : Form
   {
      public AdminEvents()
      {
         InitializeComponent();
      }

      private void AdminDashboard_Load(object sender, EventArgs e)
      {
         labelFirstname.Text = Login.setfirstname;
         labelLastname.Text = Login.setlastname;
         btnEvents.Enabled = false;
      }

      private void button5_Click(object sender, EventArgs e)
      {
         var adminreports = new AdminReports();
         adminreports.Show();
         Hide();
      }

      private void panel1_Paint(object sender, PaintEventArgs e)
      {

      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }

      private void btnCollection_Click(object sender, EventArgs e)
      {
         var admincollection = new AdminCollection();
         admincollection.Show();
         Hide();
      }

      private void btnEvents_Click(object sender, EventArgs e)
      {
         var adminevents = new AdminEvents();
         adminevents.Show();
         Hide();
      }

      private void btnRegistration_Click(object sender, EventArgs e)
      {
         var adminregistration = new AdminRegistration();
         adminregistration.Show();
         Hide();

      }

      private void btnDashboard_Click(object sender, EventArgs e)
      {
         var admindashboard = new AdminDashboard();
         admindashboard.Show();
         Hide();
      }
   }
}
