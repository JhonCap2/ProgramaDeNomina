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
        public static string TipoDePago = Pagos.TiposP.TipoPago[0];
        public static string tpp = string.Empty;
        public static double Restante= 0 ;
        public static double Total = 0;

        static void Main(string[] args)
        {
            string Nombre = string.Empty;
            double Salario = 0;
            int Horas = 0;
            double Seguros = 0;
          
            Console.WriteLine("Nomina o Servicio:");
            tpp = Console.ReadLine();

            if (TipoDePago == tpp)
            {
                Console.WriteLine("Empleado:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Salario");
                Salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Horas Trabajadas:");
                Horas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Seguros:");
                Seguros = Convert.ToDouble(Console.ReadLine());

                Restante = Salario * Horas - Seguros;

                Console.WriteLine("El Salario de" + " " 
                                  + Nombre + " "
                                  + "Es el siguiente " + " "
                                  + Restante + " "
                                  + "Este salario esta: " + " "
                                  + Simgleton.Proceso.Procesar(""));

            }
            else 
            {

                double[] APagar = new double[Pagos.TiposP.Servicio.Length];
                for (int i = 0; i < Pagos.TiposP.Servicio.Length; i++)
                {
                    Console.WriteLine(Pagos.TiposP.Servicio[i]);
                    
                    APagar[i] = Convert.ToDouble(Console.ReadLine());
                }
                Total = APagar.Sum();
                Console.WriteLine("Total de servicio a pagar: " +" "+ Total +" "+ "Esta operacion fue:" +" "+ Simgleton.Proceso.Procesar(""));
            }
            Console.WriteLine("Presiona un boton para continuar...");
            Console.ReadKey();
        }
    }
}
 