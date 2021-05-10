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
   public partial class AddCollection : Form
   {
      public AddCollection()
      {
         InitializeComponent();
      }

      private void AddCollection_Load(object sender, EventArgs e)
      {
         txtID.Text = AdminCollection.setID;
         txtFirstName.Text = AdminCollection.setFirstname;
         txtLastName.Text = AdminCollection.setLastname;
         setComboBox();
      }

      public void setComboBox()
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT EventId, (EventName + ' - Php' + CONVERT(varchar, cast(EventPrice AS MONEY), 1)) AS NAME, DateRegistered FROM Events";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            DataTable dt = new DataTable();
            SqlDataAdapter data = null;
            data = new SqlDataAdapter(Functions.Function.command);
            data.Fill(dt);
            cmbEvents.DisplayMember = "NAME";
            cmbEvents.ValueMember = "eventId";
            cmbEvents.DataSource = dt;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnCollect_Click(object sender, EventArgs e)
      {
         string Paid = "Paid";
         string Collector = Login.setfirstname + " " + Login.setlastname;

         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO Collections(EventId, UserId, Status, CollectionDate, CollectedBy) VALUES('" + txtEventID.Text + "', '" + txtID.Text + "', '"+ Paid +"', '" + DateTime.Now.ToString("dd-MM-yyyy") + "', '"+ Collector +"')";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Collection saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT * FROM Events (EventName + ' - Php' + CONVERT(varchar, cast(EventPrice AS MONEY), 1)) = '"+ cmbEvents.Text +"' ";
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.Read())
            {
               txtEventID.Text = Functions.Function.reader[0].ToString();
               Functions.Function.reader.Close();
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
