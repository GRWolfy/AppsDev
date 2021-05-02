using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AppsDev
{
   public partial class Register : Form
   {
      private bool[] EachCheck = new bool[8];
      private bool checker = false;
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
            EachCheck[3] = true;
         }
         else if (rbtnFemale.Checked)
         {
            gender = "Female";
            rbtnMale.Checked = false;
            rbtnOther.Checked = false;
            EachCheck[3] = true;
         }
         else
         {
            gender = "Other";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            EachCheck[3] = true;
         }
         for (int i = 0; i < EachCheck.Length; i++)
         {
            if (EachCheck[i] == false)
            {
               MessageBox.Show("Please review your inputs", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               checker = false;
               break;
            }
            else if (EachCheck[i] == true && i == EachCheck.Length - 1)
            {
               checker = true;
            }
         }

         if (checker)
         {
            try
            {
               btnSave.Enabled = true;
               Connection.Connection.DB();
               Functions.Function.gen = "INSERT INTO Users(FirstName, LastName, Age, Gender, Status, Username, Password, Dateregistered, RoleId, Email)values('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtAge.Text + "', '" + gender + "', '" + cmboxStatus.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', '" + 1 + "', '" + txtEmail.Text + "')";
               Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
               Functions.Function.command.ExecuteNonQuery();
               MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Connection.Connection.con.Close();
               Login login = new Login();
               login.Show();
               Hide();
            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }  
      }

      private void btnBack_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }

      private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
      {
         char ch = e.KeyChar;

         if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
         {
            e.Handled = true;
            btnSave.Enabled = false;
            EachCheck[2] = false;
         }
         else
         {
            btnSave.Enabled = true;
            EachCheck[2] = true;
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
               btnSave.Enabled = false;
               EachCheck[5] = false;
            }
            else
            {
               labelUsername.Text = "Username available";
               btnSave.Enabled = true;
               EachCheck[5] = true;
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
            EachCheck[6] = true;
         }
         else
         {
            btnSave.Enabled = false;
            labelPassword.Text = "Check password";
            EachCheck[6] = false;
         }
      }

      private void txtPassword_KeyUp(object sender, KeyEventArgs e)
      {
         if (txtPassword.Text.Equals(txtConfirmPassword.Text))
         {
            btnSave.Enabled = true;
            labelPassword.Text = "Matched";
            EachCheck[6] = true;
         }
         else
         {
            btnSave.Enabled = false;
            labelPassword.Text = "Check password";
            EachCheck[6] = false;
         }
      }

      private void Register_Load(object sender, EventArgs e)
      {
         for (int i = 0; i < EachCheck.Length; i++)
         {
            EachCheck[i] = false;
         }
      }

      private void cmboxStatus_SelectedValueChanged(object sender, EventArgs e)
      {
         EachCheck[4] = true;
      }

      private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (txtFirstName.Text == null)
         {
            EachCheck[0] = false;
         }
         else
         {
            EachCheck[0] = true; ;
         }
      }

      private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (txtLastName.Text == null)
         {
            EachCheck[1] = false;
         }
         else
         {
            EachCheck[1] = true; ;
         }
      }

      private void txtEmail_KeyUp(object sender, KeyEventArgs e)
      {
         bool check = false;
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT * FROM Users WHERE  Email = '" + txtEmail.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               check = false;
            }
            else
            {
               check = true;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

         if (IsValidEmail(txtEmail.Text) && check)
         {
            btnSave.Enabled = true;
            labelEmail.Text = "OK";
            EachCheck[7] = true;
         }
         else
         {
            btnSave.Enabled = false;
            labelEmail.Text = "Invalid email";
            EachCheck[7] = false;
         }
      }
   }
}
