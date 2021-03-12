using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace provarumo.Repository
{
    public class pedidoRepository
    {
        public string recuperarPedidos(int numeroPedido)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=ServerName;" +
             "Initial Catalog=DataBaseName;" +
             "User id=UserName;" +
             "Password=Secret;";
            conn.Open();
            return "";
        }
    }
}
