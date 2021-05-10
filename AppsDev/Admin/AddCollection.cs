using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
      }

      public void setComboBox()
      {
         try
         {
            Connection.Connection.DB();

         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
