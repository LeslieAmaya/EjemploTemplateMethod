using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTemplateMethod
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            Pedido pedidoEspaña = new PedidoEspaña();
            pedidoEspaña.setImporteSinIVA(10000.25);
            pedidoEspaña.calculaPrecioConIVA();
            pedidoEspaña.visualiza();


            Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
            pedidoLuxemburgo.setImporteSinIVA(10000.25);
            pedidoLuxemburgo.calculaPrecioConIVA();
            pedidoLuxemburgo.visualiza();
        }
    }
}
