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

                        Console.WriteLine("Ingrese el Monto de la cuota mensual !");
                        float cuota = float.Parse(Console.ReadLine());
                        CAlumno.cuota = cuota;

                        break;

                    case 2:

                        Console.WriteLine("INGRESE  el Nombre del Estudiante ");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("INGRESE  EL Apellido del Estudiante!");
                        string apellido = Console.ReadLine();

                        Console.WriteLine("INGRESE  el LEGAJO  del Estudiante!");
                        uint legajo = uint.Parse(Console.ReadLine());

                        Console.WriteLine("INGRESE  EL DESCUENTO del Estudiante !");
                        float descuento = float.Parse(Console.ReadLine());

                        

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
