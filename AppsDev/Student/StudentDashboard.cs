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
               lblTotalPayments.Text = (Functions.Function.reader["Total"].ToString());
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
