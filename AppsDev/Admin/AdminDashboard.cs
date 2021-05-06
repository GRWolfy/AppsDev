using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppsDev.Admin
{
   public partial class AdminDashboard : Form
   {
      public AdminDashboard()
      {
         InitializeComponent();
      }

      private void AdminDashboard_Load(object sender, EventArgs e)
      {
         labelFirstname.Text = Login.setfirstname;
         labelLastname.Text = Login.setlastname;
         TotalCountRegister();
         btnDashboard.Enabled = false;
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

      private void TotalCountRegister()
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT COUNT(*) AS total FROM Users WHERE RoleId = 1";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();
               lblTotalRegistration.Text = (Functions.Function.reader["total"].ToString());
            }
         }

         catch (Exception ex)
         {
            Connection.Connection.con.Close();
            MessageBox.Show(ex.Message);
         }
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

      private void linklViewRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var adminregistration = new AdminRegistration();
         adminregistration.Show();
         adminregistration.showTabControl();
         Hide();
      }

      private void linklViewCollection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var admincollection = new AdminCollection();
         admincollection.Show();
         Hide();
      }

      private void linklViewEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var adminevents = new AdminEvents();
         adminevents.Show();
         Hide();
      }
   }
}
