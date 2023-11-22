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
            Pedido pedidoEspaña = new PedidoEspaña(); //Mostramos el pedido de España
            pedidoEspaña.setImporteSinIVA(1234.12); //Ingresamos cantidad para el uso de los métodos (decimal opcional)
            pedidoEspaña.calculaPrecioConIVA();
            pedidoEspaña.visualiza();

            Pedido pedidoLuxemburgo = new PedidoLuxemburgo(); //Mostramos el pedido de Luxemburgo
            pedidoLuxemburgo.setImporteSinIVA(1234.12); //Ingresamos cantidad para el uso de los métodos (decimal opcional)
            pedidoLuxemburgo.calculaPrecioConIVA();
            pedidoLuxemburgo.visualiza();
        }
    }
}
