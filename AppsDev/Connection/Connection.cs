using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDev.Connection
{
   class Connection
   {
      public static SqlConnection con;
      private static string dbconnect = "Data Source=WOLF;Initial Catalog=TestingDb;Integrated Security=True"; //connection string

      public static void DB()
      {
         try
         {
            con = new SqlConnection(dbconnect);
            con.Open();
         }
         catch (Exception e)
         {
            con.Close();
            MessageBox.Show(e.Message);
         }
      }
   }
}
