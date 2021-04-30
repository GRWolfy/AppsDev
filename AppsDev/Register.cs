using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AppsDev
{
   public partial class Register : Form
   {
      public Register()
      {
         InitializeComponent();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         string gender = "";
         if (rbtnMale.Checked)
         {
            gender = "Male";
            rbtnFemale.Checked = false;
            rbtnOther.Checked = false;
         }
         else if (rbtnFemale.Checked)
         {
            gender = "Female";
            rbtnMale.Checked = false;
            rbtnOther.Checked = false;
         }
         else
         {
            gender = "Other";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
         }

         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO Users(FirstName, LastName, Age, Gender, Status, Username, Password, Dateregistered, RoleId, Email)values('"+txtFirstName.Text+"', '"+txtLastName.Text+ "', '" + txtAge.Text + "', '" +gender + "', '" + cmboxStatus.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', '" + 1 + "', '" + txtEmail.Text + "')";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Success", "Login", MessageBoxButtons.OK);
            Connection.Connection.con.Close();
            Login login = new Login();
            login.Show();
            Hide();
         }

         catch(Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnBack_Click(object sender, EventArgs e)
      {
         Home home = new Home();
         home.Show();
         Hide();
      }

      private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
      {
         char ch = e.KeyChar;

         if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
         {
            e.Handled = true;
            btnSave.Enabled = false;
         }
         else
         {
            btnSave.Enabled = true;
         }
      }

      private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (IsValidEmail(txtEmail.Text))
         {
            btnSave.Enabled = true;
            labelEmail.Text = "OK";
         }
         else
         {
            btnSave.Enabled = false;
            labelEmail.Text = "Invalid email";
         }
      }

      public bool IsValidEmail(string email)
      {
         try
         {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
         }
         catch
         {
            return false;
         }
      }

      private void txtUsername_KeyUp(object sender, KeyEventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT * FROM users WHERE  Username = '" + txtUsername.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               labelUsername.Text = "Username already exist";
            }
            else
            {
               labelUsername.Text = "Username available";
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void txtConfirmPassword_KeyUp(object sender, KeyEventArgs e)
      {
         if (txtPassword.Text.Equals(txtConfirmPassword.Text))
         {
            btnSave.Enabled = true;
            labelPassword.Text = "Matched";
         }
         else
         {
            btnSave.Enabled = false;
            labelPassword.Text = "Check password";
         }
      }

      private void txtPassword_KeyUp(object sender, KeyEventArgs e)
      {
         if (txtPassword.Text.Equals(txtConfirmPassword.Text))
         {
            btnSave.Enabled = true;
            labelPassword.Text = "Matched";
         }
         else
         {
            btnSave.Enabled = false;
            labelPassword.Text = "Check password";
         }
      }
   }
}
