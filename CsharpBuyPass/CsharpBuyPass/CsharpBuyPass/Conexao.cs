using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBuyPass
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao() {
            con.ConnectionString = @"Data Source=LAPTOP-6R2QTKQ1;Initial Catalog=BD_BuyPass;User ID=sa;Password=12345";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }



        //metodos desconectar 
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
