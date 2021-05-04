using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppsDev.Admin
{
   public partial class AdminRegistration : Form
   {
      public AdminRegistration()
      {
         InitializeComponent();
      }

      private void AdminDashboard_Load(object sender, EventArgs e)
      {
         labelFirstname.Text = Login.setfirstname;
         labelLastname.Text = Login.setlastname;
         btnRegistration.Enabled = false;
         getRegistration();
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

      private void btnSave_Click(object sender, EventArgs e)
      {
         string gender = "";
         if (rbtnMale.Checked)
         {
            gender = "Male";
            rbtnFemale.Checked = false;
            rbtnOther.Checked = false;
            //EachCheck[3] = true;
         }
         else if (rbtnFemale.Checked)
         {
            gender = "Female";
            rbtnMale.Checked = false;
            rbtnOther.Checked = false;
            //EachCheck[3] = true;
         }
         else
         {
            gender = "Other";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            //EachCheck[3] = true;
         }

         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO Users(FirstName, LastName, Age, Gender, Status, Username, Password, Dateregistered, RoleId, Email)values('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtAge.Text + "', '" + gender + "', '" + cmboxStatus.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + DateTimePicker.Value.Date + "', '" + txtRoleId.Text + "', '" + txtEmail.Text + "')";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      public void getRegistration()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT * FROM Users INNER JOIN Role ON Role.RoleId = Users.RoleId WHERE Role.RoleId = 1;";
         Functions.Function.fill(Functions.Function.gen, dataGridRegister);
      }

      public void showTabControl() 
      {
         tabControlRegistration.SelectedIndex = 1;
      }
   }
}

/*
   
 */