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
      }

      private void button5_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }

      private void panel1_Paint(object sender, PaintEventArgs e)
      {

      }

      private void lblTotalRegistration_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT COUNT(*) AS total FROM Users INNER JOIN Role on Role.RoleId = Users.RoleId WHERE Role.RoleId = 1";
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
   }
}
