using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Libreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=WIZJUANRD\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True");
            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            da.Fill(ds);

            con.Close();
            return ds;
        }
    }
}
