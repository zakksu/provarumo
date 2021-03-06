using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace provarumo.Models.Entities
{
    public class PedidoEntity
    {
        public int NumeroPedido { get; set; }
        public int NumeroMesa { get; set; }
        public string NomeCliente { get; set; }
        public string Prato { get; set; }
        public string Bebida { get; set; }
        public int Quantidade { get; set; }
    }
}
