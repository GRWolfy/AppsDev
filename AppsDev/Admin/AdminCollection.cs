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
         getRecords();
         ViewCollection();
         tabControlCollection.SelectedIndex = 1;
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

      public void getRecords()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT Users.UserId AS [USER ID], Users.FirstName AS [FIRST NAME], Users.LastName AS [LAST NAME], Users.Age AS [AGE], Users.Gender AS [GENDER], Users.Status AS [STATUS], Users.Username AS [USERNAME], Users.Password AS [PASSWORD], Users.Dateregistered AS [DATE REGISTERED], Role.RoleId as [ROLE], Users.Email AS [EMAIL] FROM Users INNER JOIN Role ON Role.RoleId = Users.RoleId WHERE Users.RoleId = 1";
         Functions.Function.fill(Functions.Function.gen, dataGridCollection);
      }

      public void ViewCollection()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT Users.UserId AS [USER ID], Users.FirstName AS [FIRST NAME], Users.LastName AS [LAST NAME], Events.Eventname AS [EVENT], Events.Eventprice AS [EVENT FEE], Collections.Status AS [STATUS], Collections.CollectionDate AS [DATE COLLECTED], Collections.CollectedBy AS [COLLECTED BY] FROM Users INNER JOIN Collections ON Users.UserId = Collections.UserId INNER JOIN Events On Events.EventId = Collections.EventId";
         Functions.Function.fill(Functions.Function.gen, dataGridViewCollections);
      }

      private void dataGridCollection_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         var collect = new AddCollection();
         setID = dataGridViewCollections.CurrentRow.Cells[0].Value.ToString();
         setFirstname = dataGridViewCollections.CurrentRow.Cells[1].Value.ToString();
         setLastname = dataGridViewCollections.CurrentRow.Cells[2].Value.ToString();
         collect.Show();
         Hide();
      }

      public void showTabControl()
      {
         tabControlCollection.SelectedIndex = 1;
      }
   }
}