using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppsDev.Admin
{
   public partial class AdminReports : Form
   {
      private string fullname = Login.setfirstname + " " + Login.setlastname;
      private string totalsales = AdminDashboard.setTotalCollection;
      public AdminReports()
      {
         InitializeComponent();
      }

      private void AdminReports_Load(object sender, EventArgs e)
      {
         labelFirstname.Text = Login.setfirstname;
         labelLastname.Text = Login.setlastname;
         btnReports.Enabled = false;
         lblTotalSales.Text = "Php" + Decimal.Parse(totalsales).ToString("N2");
         ViewReports();
         
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
         txtTotalSales.Text = totalsales;

         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO Reports(ReportSubject, ReportBody, ReportedTotalSales, ReportEncodedby, DateRegistered) VALUES('" + txtReportSubject.Text + "', '" + txtReportBody.Text + "', '" + txtTotalSales.Text + "', '" + fullname + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' )";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Report saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
            ViewReports();
            ResetFormControls();
            tabControl1.SelectedIndex = 1;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      public void ViewReports()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT Reports.ReportId AS [REPORT ID], Reports.ReportSubject AS [REPORT SUBJECT], Reports.ReportBody AS [REPORT BODY], 'Php' + convert(varchar, cast(Reports.ReportedTotalSales AS MONEY), 1) AS [REPORTED TOTAL SALES], Reports.ReportEncodedby AS [ENCODED BY], Reports.DateRegistered AS [DATE REGISTERED] FROM Reports";
         Functions.Function.fill(Functions.Function.gen, dataGridViewReports);
      }

      private void dataGridViewReports_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         txtReportId.Text = dataGridViewReports[0, e.RowIndex].Value.ToString();
         txtReportSubject.Text = dataGridViewReports[1, e.RowIndex].Value.ToString();
         txtReportBody.Text = dataGridViewReports[2, e.RowIndex].Value.ToString();
         btnSave.Enabled = false;
         btnUpdate.Enabled = true;
         btnDelete.Enabled = true;
         tabControl1.SelectedIndex = 0;
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "UPDATE Reports SET ReportSubject = '"+ txtReportSubject.Text +"', ReportBody = '"+ txtReportBody +"', ReportEncodedby = '"+ fullname +"', DateRegistered = '"+ DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE RoleId = '"+ txtReportId.Text +"'  ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewReports();
            ResetFormControls();
            tabControl1.SelectedIndex = 1;
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
            var gen = MessageBox.Show("Are you sure you want to delete this report?", "Delete report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Functions.Function.gen = "DELETE FROM Reports WHERE ReportId = '" + txtReportId.Text + "' ";
               Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
               Functions.Function.command.ExecuteNonQuery();
               Connection.Connection.con.Close();
               ResetFormControls();
               AdminReports_Load(sender, e);
               tabControl1.SelectedIndex = 1;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void ResetFormControls()
      {
         txtReportBody.Clear();
         txtReportEncodedby.Clear();
         txtReportId.Clear();
         txtTotalSales.Clear();
         txtReportSubject.Clear();
      }
   }
}
