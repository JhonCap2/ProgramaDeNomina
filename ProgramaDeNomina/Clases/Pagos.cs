using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDeNomina.Clases
{
    public class Pagos
    {
        public string[] TipoPago = { "Servicio", "Salarios" };
        public double[] PagoARealizar = { 15000.00, 20000.00, 25000.00, 30000.00 };
        public string[] Servicio = { "Seguros", "Oficina", "Bodega", "Mensajero" };
        private Pagos() 
        {
          
        }
        public static Pagos TiposP
        {
            get { return new Pagos();}
        }

         
        


    }
}
