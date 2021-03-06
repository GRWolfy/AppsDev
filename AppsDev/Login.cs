using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDev
{
   public partial class Login : Form
   {
      public static string setfirstname = "";
      public static string setlastname = "";
      public static int setuserId = 0;
      public Login()
      {
         InitializeComponent();
      }

      private void linklRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var register = new Register();
         register.Show();
         Hide();
      }

      private void btnLoginAccount_Click(object sender, EventArgs e)
      {
         int roleid;
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT * FROM Users WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();

               roleid = Convert.ToInt32(Functions.Function.reader["RoleId"]);

               if (roleid == 1)
               {
                  txtUsername.Text = Functions.Function.reader["Username"].ToString();
                  txtPassword.Text = Functions.Function.reader["Password"].ToString();

                  setfirstname = Functions.Function.reader["FirstName"].ToString();
                  setlastname = Functions.Function.reader["LastName"].ToString();
                  setuserId = Convert.ToInt32(Functions.Function.reader["UserId"]);

                  var student = new Student.StudentDashboard();
                  student.Show();
                  Hide();
               }
               else if (roleid == 2)
               {
                  txtUsername.Text = Functions.Function.reader["Username"].ToString();
                  txtPassword.Text = Functions.Function.reader["Password"].ToString();

                  setfirstname = Functions.Function.reader["FirstName"].ToString();
                  setlastname = Functions.Function.reader["LastName"].ToString();

                  var admin = new Admin.AdminDashboard();
                  admin.Show();
                  Hide();
               }
            }
            else
            {
               MessageBox.Show("Incorrect username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }


      }

      private void Login_Load(object sender, EventArgs e)
      {
         tooltipPaimon.SetToolTip(pictureBox1, "Do you need help?");
         pictureBox2.Visible = false;
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {
         pictureBox1.Visible = false;
         pictureBox2.Visible = true;
         tooltipAngry.SetToolTip(pictureBox2, "PAIMON DOESN'T WANT TO HELP YOU!");

      }
   }
}
