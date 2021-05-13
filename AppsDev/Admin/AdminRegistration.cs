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

      private void AdminRegistration_Load(object sender, EventArgs e)
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

      private string getGender()
      {
         string gender = "";

         if (rbtnMale.Checked)
         {
            rbtnFemale.Checked = false;
            rbtnOther.Checked = false;
            gender = "Male";
         }
         else if (rbtnFemale.Checked)
         {
            rbtnMale.Checked = false;
            rbtnOther.Checked = false;
            gender = "Female";
         }
         else
         {
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            gender = "Other";
         }

         return gender;
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO Users(FirstName, LastName, Age, Gender, Status, Username, Password, Dateregistered, RoleId, Email)values('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtAge.Text + "', '" + getGender() + "', '" + cmboxStatus.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + DateTime.Now.ToString("dd-MM-yyyy") + "', '" + 1 + "', '" + txtEmail.Text + "')";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getRegistrationALL();
            tabControlRegistration.SelectedIndex = 1;
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
         Functions.Function.gen = "SELECT Users.UserId AS [USER ID], Users.FirstName AS [FIRST NAME], Users.LastName AS [LAST NAME], Users.Age AS [AGE], Users.Gender AS [GENDER], Users.Status AS [STATUS], Users.Username AS [USERNAME], Users.Password AS [PASSWORD], Users.Dateregistered AS [DATE REGISTERED], Role.RoleId as [ROLE], Users.Email AS [EMAIL] FROM Users INNER JOIN Role ON Role.RoleId = Users.RoleId WHERE Users.RoleId = 1";
         Functions.Function.fill(Functions.Function.gen, dataGridRegister);
      }

      public void getRegistrationALL()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT Users.UserId AS [USER ID], Users.FirstName AS [FIRST NAME], Users.LastName AS [LAST NAME], Users.Age AS [AGE], Users.Gender AS [GENDER], Users.Status AS [STATUS], Users.Username AS [USERNAME], Users.Password AS [PASSWORD], users.Dateregistered AS [DATE REGISTERED], Role.RoleId as [ROLE] FROM Users INNER JOIN Role ON Role.RoleId = Users.RoleId";
         Functions.Function.fill(Functions.Function.gen, dataGridRegister);
      }

      public void showTabControl() 
      {
         tabControlRegistration.SelectedIndex = 1;
      }

      private void dataGridRegister_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         try
         {
            txtUserid.Text = dataGridRegister[0, e.RowIndex].Value.ToString();
            txtFirstName.Text = dataGridRegister[1, e.RowIndex].Value.ToString();
            txtLastName.Text = dataGridRegister[2, e.RowIndex].Value.ToString();
            txtAge.Text = dataGridRegister[3, e.RowIndex].Value.ToString();

            if (dataGridRegister.CurrentRow.Cells[4].FormattedValue.Equals("Male"))
            {
               rbtnMale.Checked = true;
               rbtnFemale.Checked = false;
               rbtnOther.Checked = false;
            }
            else if (dataGridRegister.CurrentRow.Cells[4].FormattedValue.Equals("Female"))
            {
               rbtnMale.Checked = false;
               rbtnFemale.Checked = true;
               rbtnOther.Checked = false;
            }
            else 
            {
               rbtnMale.Checked = false;
               rbtnFemale.Checked = false;
               rbtnOther.Checked = true;
            }

            cmboxStatus.Text = dataGridRegister[5, e.RowIndex].Value.ToString();
            txtUsername.Text = dataGridRegister[6, e.RowIndex].Value.ToString();
            txtPassword.Text = dataGridRegister[7, e.RowIndex].Value.ToString();
            DateTimePick.Value = Convert.ToDateTime(dataGridRegister.Rows[e.RowIndex].Cells[8].Value.ToString());
            txtRoleId.Text = dataGridRegister[9, e.RowIndex].Value.ToString();
            txtEmail.Text = dataGridRegister[10, e.RowIndex].Value.ToString();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            lblRoleid.Visible = true;
            lblDate.Visible = true;
            //lblUserid.Visible = true;
            DateTimePick.Visible = true;
            txtRoleId.Visible = true;
            //txtUserid.Visible = true;

            tabControlRegistration.SelectedIndex = 0;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "UPDATE Users SET FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text + "', Age = '" + txtAge.Text + "', Gender = '" + getGender() + "', Status = '" + cmboxStatus.Text + "', Username = '" + txtUsername.Text + "', Password = '" + txtPassword.Text + "', Dateregistered = '" + DateTimePick.Value.Date + "', RoleId = '" + txtRoleId.Text + "', Email = '" + txtEmail.Text + "' WHERE userid = '" + txtUserid.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getRegistrationALL();
            tabControlRegistration.SelectedIndex = 1;
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Functions.Function.gen = "DELETE FROM Users WHERE UserId = '" + txtUserid.Text + "' ";
               Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
               Functions.Function.command.ExecuteNonQuery();
               Connection.Connection.con.Close();
               AdminRegistration_Load(sender, e);
               tabControlRegistration.SelectedIndex = 1;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void txrSearch_TextChanged(object sender, EventArgs e)
      {
         try
         {
            Functions.Function.gen = "SELECT * FROM Users WHERE UserId LIKE '" + txtSearch.Text + "%' OR FirstName LIKE '" + txtSearch.Text + "%' OR LastName LIKE '" + txtSearch.Text + "%' OR Username LIKE '" + txtSearch.Text + "%' OR Email LIKE '" + txtSearch.Text + "%' OR RoleId LIKE '" + txtSearch.Text + "%' ";
            Functions.Function.fill(Functions.Function.gen, dataGridRegister);
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void rbtnLastName_CheckedChanged(object sender, EventArgs e)
      {
         try
         {
            Functions.Function.gen = "SELECT * FROM USERS ORDER BY '"+ rbtnLastName.Text +"' ";
            Functions.Function.fill(Functions.Function.gen, dataGridRegister);
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}