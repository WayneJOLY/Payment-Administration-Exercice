using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_payment_Administration
{
    internal class CInterfaz
    {

        static CInterfaz(){
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void MostrarOpcion()
        {
            Console.Clear();


            Console.WriteLine("[1] Ingrese La Cuota de refrencia De la Escuela");
            Console.WriteLine("[2] Registrar Los Datos de un Alumno ");
            Console.WriteLine("[3] Listar Los datos de Todos los Alumnos");
            Console.WriteLine("[4] Salir ");
        }

    }
}
