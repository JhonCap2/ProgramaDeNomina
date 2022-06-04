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
            for (int i = 0; i < Pagos.TiposP.PagoARealizar.Length; i++)
            {
                if (Pagos.TiposP.PagoARealizar[i] == Program.Restante)
                {
                    mensaje = "Procesado correctamente";
                    
                }
                else
                {
                    mensaje = "No logro ser procesado";
                }
            }
            return mensaje;
        }
    }
}
