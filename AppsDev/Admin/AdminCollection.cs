using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppsDev.Admin
{
   public partial class AdminCollection : Form
   {
      public static string setID;
      public static string setFirstname;
      public static string setLastname;

      public AdminCollection()
      {
         InitializeComponent();
      }

      private void AdminCollection_Load(object sender, EventArgs e)
      {
         labelFirstname.Text = Login.setfirstname;
         labelLastname.Text = Login.setlastname;
         btnCollection.Enabled = false;
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

      private void dataGridCollections_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         var collect = new AddCollection();
         setID = dataGridCollections.CurrentRow.Cells[0].Value.ToString();
         setFirstname = dataGridCollections.CurrentRow.Cells[1].Value.ToString();
         setLastname = dataGridCollections.CurrentRow.Cells[2].Value.ToString();
         collect.Show();
         Hide();
      }
   }
}
