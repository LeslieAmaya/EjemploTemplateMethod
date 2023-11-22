using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTemplateMethod
{
    public class PedidoLuxemburgo : Pedido
    {
        protected override void calculaIVA()
        {
            importeIVA = importeSinIVA * 0.17;
        }
    }
}
