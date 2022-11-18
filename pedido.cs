using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurídico
{
    class pedido
    {
        public int numero { get; set; }
        public double valorpedido { get; set; }
        public string descriminaçãopedido { get; set; }

        public double getvalorpedidoglobal()
        {
            return 1;
        }
        public double getvalorquantidadeglobal()
        {
            return 1;
        }
    }
}
