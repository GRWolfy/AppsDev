using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppsDev.Admin
{
   public partial class AdminEvents : Form
   {
      public AdminEvents()
      {
         InitializeComponent();
      }

      private void AdminEvents_Load(object sender, EventArgs e)
      {
         labelFirstname.Text = Login.setfirstname;
         labelLastname.Text = Login.setlastname;
         btnEvents.Enabled = false;
         getEvents();
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
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO Events(Eventname, Eventprice, Dateregistered) VALUES('" + txtEventname.Text + "', '" + txtEventprice.Text + "', '" + DateTime.Now.ToString("dd-MM-yyyy") + "')";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Event saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getEvents();
            tabControlEvents.SelectedIndex = 1;
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void getEvents()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT Events.EventId AS [EVENT ID], Events.Eventname AS [EVENT NAME], Events.Eventprice AS [EVENT PRICE], Events.Dateregistered AS [DATE REGISTERED] FROM Events";
         Functions.Function.fill(Functions.Function.gen, dataGridEvents);
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "UPDATE Events SET Eventname = '" + txtEventname.Text + "', Eventprice = '" + txtEventprice.Text +"', dateregistered = '"+ DateTimePick.Value.Date + "' WHERE EventId = '"+ txtEventid.Text +"' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getEvents();
            tabControlEvents.SelectedIndex = 1;
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
               Functions.Function.gen = "DELETE FROM Events WHERE EventId = '" + txtEventid.Text + "' ";
               Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
               Functions.Function.command.ExecuteNonQuery();
               Connection.Connection.con.Close();
               AdminEvents_Load(sender, e);
               tabControlEvents.SelectedIndex = 1;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void dataGridEvents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         try
         {
            txtEventid.Text = dataGridEvents[0, e.RowIndex].Value.ToString();
            txtEventname.Text = dataGridEvents[1, e.RowIndex].Value.ToString();
            txtEventprice.Text = dataGridEvents[2, e.RowIndex].Value.ToString();
            DateTimePick.Value = Convert.ToDateTime(dataGridEvents.Rows[e.RowIndex].Cells[3].Value.ToString());


            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            lblDate.Visible = true;
            DateTimePick.Visible = true;

            tabControlEvents.SelectedIndex = 0;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
