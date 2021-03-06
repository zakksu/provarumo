using provarumo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace provarumo.UI.Models
{
    public class PedidoModel
    {
        public List<PedidoEntity> Listar()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=DESKTOP-8QDCBBS;" +
            "Initial Catalog=ProvaRumo;" +
            "User id=godinho;" +
            "Password=provarumo;";

            var query = "SELECT [NumeroPedido]" +
                              ",[NomeCliente]" +
                              ",[Prato]" +
                              ",[Bebida]" +
                              ",[NumeroMesa]" +
                              ",[Quantidade]" +
                              "FROM[dbo].[Pedido]";

            SqlCommand command = new SqlCommand(query, conn);
            command.Connection.Open();
            var reader = command.ExecuteReader();

            var pedidos = new List<PedidoEntity>();

            while (reader.Read())
            {
                var pedido = new PedidoEntity { NomeCliente = (string)reader["NomeCliente"],
                                                Prato = (string)reader["Prato"],
                                                Bebida = (string)reader["Bebida"],
                                                NumeroMesa = (int)reader["NumeroMesa"],
                                                Quantidade = (int)reader["Quantidade"]
                };

                pedidos.Add(pedido);
            }

            return pedidos;
        }

        public void Inserir(PedidoEntity pedido)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=DESKTOP-8QDCBBS;" +
            "Initial Catalog=ProvaRumo;" +
            "User id=godinho;" +
            "Password=provarumo;";

            var query = "INSERT INTO [dbo].[Pedido]" +
                                         "([NomeCliente]" +
                                         ",[Prato]" +
                                         ",[Bebida]" +
                                         ",[NumeroMesa]" +
                                         ",[Quantidade])" +
                                         "VALUES" +
                                         "('" + pedido.NomeCliente + "'" +
                                         ",'" + pedido.Prato + "'" +
                                         ",'" + pedido.Bebida + "'" +
                                         "," + pedido.NumeroMesa +
                                         "," + pedido.Quantidade + ");";

            SqlCommand command = new SqlCommand(query, conn);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
