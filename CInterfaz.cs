using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_payment_Administration
{
    public class CInterfaz
    {

        static CInterfaz(){
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public string MostrarOpcion()
        {
            Console.Clear();

            Console.Write("\n ----- ------------------------------------- -------------------");
            Console.Write("                                                               -");
            Console.Write("       ADMINISTRACION DE PAGOS DE LA ESCUELA                   -");
            Console.Write("                                                               -");
            Console.Write(" ----- ------------------------------------- -------------------\n");
            Console.WriteLine("[1] Ingrese La Cuota de refrencia De la Escuela");
            Console.WriteLine("[2] Registrar Los Datos de un Alumno ");
            Console.WriteLine("[3] Listar Los datos de Todos los Alumnos");
            Console.WriteLine("[0] Salir ");

            return Console.ReadLine();
        }

    }
}
