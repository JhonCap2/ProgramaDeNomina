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

        public static string Proces = Simgleton.Proceso.Procesar("");
        public string TipoDePago = Pagos.TiposP.TipoPago[0];
        public static double Restante= 0 ;

        static void Main(string[] args)
        {
            

            string Nombre = string.Empty;
            double Salario = 0;
            int Horas = 0;
            double Seguros = 0;
            
            int es = 1;

            Console.WriteLine("Nomina(1) o servicio(2):");
            int tpp = Convert.ToInt32(Console.ReadLine());

            
            if (es == tpp)
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

                Console.WriteLine("El Salario de"
                                  + Nombre
                                  + "Es el siguiente "
                                  + Restante
                                  + "Este salario esta: "
                                  + Proces);

            }
            else 
            {

                double[] APagar = { };
                for (int i = 0; i < Pagos.TiposP.Servicio.Length; i++)
                {
                    Console.WriteLine(Pagos.TiposP.Servicio[i]);
                    
                    APagar[i] = Convert.ToDouble(Console.ReadLine());
                }
                var Total = APagar.Sum();
                Console.WriteLine("Total de servicio a pagar: " + Total);


            }


            



        }
    }
}
 