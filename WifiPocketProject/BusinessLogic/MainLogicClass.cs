using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLogic.Model.StaticModel.DashboardModel;

namespace BusinessLogic
{
    public class MainLogicClass
    {
        public static void usp_Insert(List<GridViewDbModel> _List, out string msg)
        {
            msg = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlTransaction transaction = null;

            try
            {
                string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = " + System.IO.Path.GetFullPath("ENCAPdb.mdf") + "; Integrated Security = True";  //System.Configuration.ConfigurationManager.ConnectionStrings["DbConnectionString"].ToString();

                conn = new SqlConnection(ConnectionString);
                conn.Open();
                transaction = conn.BeginTransaction();

                foreach (var item in _List)
                {
                    cmd = new SqlCommand("usp_InsertRecord", conn, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the current item in the loop
                    cmd.Parameters.AddWithValue("@Parameter", item.Parameter ?? "");
                    cmd.Parameters.AddWithValue("@Battery1", item.Battery1 ?? "");
                    cmd.Parameters.AddWithValue("@Battery2",item.Battery2 ?? "");
                    cmd.Parameters.AddWithValue("@Battery3",item.Battery3 ?? "");
                    cmd.Parameters.AddWithValue("@Battery4",item.Battery4 ?? "");
                    cmd.Parameters.AddWithValue("@Battery5",item.Battery5 ?? "");

                    // Execute the command
                    int isInserted = cmd.ExecuteNonQuery();

                    if (isInserted > 0)
                    {
                        msg = "Saved Successfully";
                    }
                    else
                    {
                        msg = "Not Saved";
                    }

                    // Dispose command to clear parameters for the next iteration
                    cmd.Dispose();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                transaction?.Rollback();
                return;
            }
            finally
            {
                // Clean up resources
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Dispose();

                if (cmd != null)
                    cmd.Dispose();
            }
        }

    }
}
