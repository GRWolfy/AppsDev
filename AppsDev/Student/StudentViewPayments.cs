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
   public partial class StudentViewPayments : Form
   {
      public string setStatus = "";
      public StudentViewPayments()
      {
         InitializeComponent();
      }

      private void StudentViewPayments_Load(object sender, EventArgs e)
      {
         labelFirstname.Text = Login.setfirstname;
         labelLastname.Text = Login.setlastname;
         btnViewPayments.Enabled = false;
         ViewPayments();
      }

      private void btnDashboard_Click(object sender, EventArgs e)
      {
         var studentdashboard = new StudentDashboard();
         studentdashboard.Show();
         Hide();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }

      public void ViewPayments()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT  events.eventid as [EVENT] , events.Eventname AS [EVENT NAME], 'Php' + convert(varchar, cast(Events.Eventprice AS MONEY), 1) AS [EVENT FEE], Events.Dateregistered AS [DATE] FROM Events";
         Functions.Function.fill(Functions.Function.gen, dataGridViewPayments);
      }

      private void dataGridViewPayments_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         txtEventId.Text = dataGridViewPayments.CurrentRow.Cells[0].Value.ToString();
         txtEventname.Text = dataGridViewPayments.CurrentRow.Cells[1].Value.ToString();
         txtEventprice.Text = dataGridViewPayments.CurrentRow.Cells[2].Value.ToString();
         txtFullname.Text = Login.setfirstname + " " + Login.setlastname;
         tabControl1.SelectedIndex = 0;
      }

      private void btnPay_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO Collections(EventId, UserId, Status, CollectionDate, CollectedBy) VALUES('" + txtEventId.Text + "', '" + Login.setuserId + "', '" + "Paid" + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', '" + "Online payment" + "')";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Collection saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
            ViewPayments();
            tabControl1.SelectedIndex = 1;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
