using System.Collections;

namespace School_payment_Administration
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CInterfaz interfaz = new CInterfaz();
            ArrayList listaDeEstudiate = new ArrayList();
            uint option;

     

            do
            {
                uint.TryParse(interfaz.MostrarOpcion(), out option);

                switch (option)
                {
                    case 1:

                        Console.WriteLine("INGRESE LA CUOTA MENSUAL !");
                        float cuota = float.Parse(Console.ReadLine());
                        CAlumno.cuota = cuota;

                        break;

                    case 2:

                        Console.WriteLine("INGRESE  EL NOMBRE DEL ESTUDINTE !");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("INGRESE  EL APELLIDO DEL ESTUDINTE !");
                        string apellido = Console.ReadLine();

                        Console.WriteLine("INGRESE  EL DESCUENTO DEL ESTUDINTE !");
                        float descuento = float.Parse(Console.ReadLine());

                        Console.WriteLine("INGRESE  EL LEGAJO DEL ESTUDINTE !");
                        uint legajo = uint.Parse(Console.ReadLine());

                        CAlumno alumno1 = new CAlumno(nombre, apellido, descuento, legajo);

                        Console.WriteLine(alumno1.ToString());
                        listaDeEstudiate.Add(alumno1);
                        break;

                    case 3:

                        Console.WriteLine("LISTA DE ESTUDIANTE");

                        foreach(CAlumno alumno in listaDeEstudiate)
                        {
                            Console.WriteLine(alumno.ToString());
                        }

                        Console.ReadLine();
                        break;
                }

            } while (option != 0);


            
        }

    }
}
