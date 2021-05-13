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

namespace AppsDev.Student
{
   public partial class StudentDashboard : Form
   {
      public StudentDashboard()
      {
         InitializeComponent();
      }

      private void StudentDashboard_Load(object sender, EventArgs e)
      {
         labelFirstname.Text = Login.setfirstname;
         labelLastname.Text = Login.setlastname;
         TotalPayment();
         TotalCountEvents();
         btnDashboard.Enabled = false;
      }

      private void TotalPayment()
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT SUM(Events.Eventprice) AS Total FROM Events INNER JOIN Collections ON Collections.EventId = Events.EventId INNER JOIN Users ON Users.UserId = Collections.UserId WHERE Users.UserId = '"+ Login.setuserId +"'";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();
               string s = (Functions.Function.reader["Total"].ToString());
               lblTotalPayments.Text = Decimal.Parse(s).ToString("N2");
            }
         }

         catch (Exception ex)
         {
            Connection.Connection.con.Close();
            MessageBox.Show(ex.Message);
         }
      }

      private void TotalCountEvents()
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT COUNT(*) AS total FROM Events";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();
               lblTotalEvents.Text = (Functions.Function.reader["total"].ToString());
            }
         }

         catch (Exception ex)
         {
            Connection.Connection.con.Close();
            MessageBox.Show(ex.Message);
         }
      }

      private void btnViewPayments_Click(object sender, EventArgs e)
      {
         var studentviewpayments = new StudentViewPayments();
         studentviewpayments.Show();
         Hide();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }
   }
}
