using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace webCinestar_WebForms_202620.Controllers

{
    public class Db
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;

    public Db(string cnn)
    {

        cn = new SqlConnection(ConfigurationManager.ConnectionStrings[cnn].ConnectionString);

     }
        internal void Sentencia(string v)
        {
            cmd = new SqlCommand(v, cn);
            //cmd.CommandType = CommandType.StoredProcedure;
        }

        internal DataTable getDataTable()
        {
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}