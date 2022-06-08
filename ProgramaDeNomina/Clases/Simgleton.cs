using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaDeNomina;

namespace ProgramaDeNomina.Clases
{
    public class Simgleton
    {
        public readonly static Simgleton _proceso = new Simgleton();

        private Simgleton()
        {

        }

        public static Simgleton Proceso 
        {
            get { return _proceso; }
        }
        public string Procesar(string mensaje) 
        {
            if (Program.tpp == Pagos.TiposP.TipoPago[1])
            {
                if (Program.Total > 0)
                {
                    mensaje = "Procesado correctamente";
                }
                else 
                {
                    mensaje = "No logro ser procesado";
                }
                
            }
            else
            {
                for (int i = 0; i < Pagos.TiposP.PagoARealizar.Length; i++)
            {
                if (Program.Restante >= Pagos.TiposP.PagoARealizar[i])
                {
                    mensaje = "Procesado correctamente";
                    
                }
                else
                {
                    mensaje = "No logro ser procesado";
                }
            }
            }
            return mensaje;
            
        }
    }
}
