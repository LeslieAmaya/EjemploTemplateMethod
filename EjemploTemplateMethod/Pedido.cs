using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTemplateMethod
{
    public abstract class Pedido
    {
        protected double importeSinIVA; //creamos el método protected para utilizarlo solo con herencia
        protected double importeIVA; //creamos el método protected para utilizarlo solo con herencia
        protected double importeConIVA; //creamos el método protected para utilizarlo solo con herencia

        protected abstract void calculaIVA(); //creamos el método protected para utilizarlo solo con herencia
        public void calculaPrecioConIVA()
        {
            this.calculaIVA();
            importeConIVA = importeSinIVA + importeIVA; //precio + precio*IVA
        }

        public void setImporteSinIVA(double importeSinIVA)
        {
            this.importeSinIVA = importeSinIVA; //cálculo de importe sin IVA
        }

        public void visualiza() //Muestra los datos de importe sin IVA y con IVA
        {
            Console.WriteLine("Pedido");
            Console.WriteLine("Importe sin IVA " + importeSinIVA);
            Console.WriteLine("Importe con IVA " + importeConIVA);
        }
    }
}
