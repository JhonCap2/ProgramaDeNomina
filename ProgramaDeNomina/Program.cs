using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaDeNomina.Clases;

namespace ProgramaDeNomina
{

    class Program
    {

        public string proceso = Simgleton.Proceso.ToString();
        public string TipoDePago = Pagos.TiposP.TipoPago[es];
        static void Main(string[] args)
        {
            

            string Nombre = string.Empty;
            double Salario = 0;
            int[] es = { 0,1,2};

            Console.WriteLine("Nomina(1) o servicio(2):");
            es = Convert.ToInt32(Console.ReadLine());


            if (es = 0)
            {
                Console.WriteLine("Empleado:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Salario");
                Salario = Convert.ToDouble(Console.ReadLine());
            }
            else 
            {
                Console.WriteLine("Servicio: "));
                Nombre = Console.ReadLine();

                Salario= Convert.ToDouble(Console.ReadLine());
            }


            if (Salario == Pagos.TiposP.TipoPago[es]) 
            {
                
            }



        }
    }
}
