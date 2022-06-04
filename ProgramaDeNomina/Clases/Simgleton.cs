using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Procesar(string mensaje) 
        {
            if(string SePago == )
            {
                mensaje = "Procesado correctamente";
            }
            else
            {
                mensaje = "No logro ser procesado";
            }
            
            
        }
    }
}
