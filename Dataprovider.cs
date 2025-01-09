using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ba_form
{
    internal class Dataprovider
    {
        private String conn;
        private SqlConnection connect;

        public Dataprovider()
        {
            conn = "Data Source=DESKTOP-9BP5UT3\\SQLEXPRESS;Initial Catalog=QuanlyDT;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            connect = new SqlConnection(conn);  
        }

        public DataTable Readdata(String query, List<SqlParameter> sqls = null)
        {
            DataTable dt = new DataTable();  
            SqlCommand cd = new SqlCommand(query, connect);
            try
            {
                connect.Open();
                if(sqls != null)
                {
                    cd.Parameters.AddRange(sqls.ToArray());
                }
                SqlDataReader reader = cd.ExecuteReader();
                dt.Load(reader, LoadOption.OverwriteChanges);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dt = null;
            }
            finally
            {
                connect.Close();
            }

            return dt;
        }

        public int WriteData(String query, List<SqlParameter> sqls = null)
        {
            int roweff = -1;
            using (SqlCommand cd = new SqlCommand(query, connect))
            {
                try
                {
                    connect.Open();
                    if(sqls != null)
                    {
                        cd.Parameters.AddRange(sqls.ToArray());
                    }                
                    roweff = cd.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connect.Close();
                }
            }
            return roweff;
        }
    }
}
