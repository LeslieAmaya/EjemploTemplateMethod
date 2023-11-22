using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTemplateMethod
{
    public class PedidoEspaña : Pedido
    {
        protected override void calculaIVA()
        {
            importeIVA = importeSinIVA * 0.2; //el importe de IVA es 0.2 en España
        }
    }
}
