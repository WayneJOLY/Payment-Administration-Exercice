namespace School_payment_Administration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL PAGO");
            Console.WriteLine("INGRESE LA CUOTA MENSUAL !");
            float cuota =float.Parse(Console.ReadLine());
            CAlumno.cuota = cuota;

            Console.WriteLine("INGRESE  EL NOMBRE DEL ESTUDINTE !");
            string nombre= Console.ReadLine();

            Console.WriteLine("INGRESE  EL APELLIDO DEL ESTUDINTE !");
            string apellido =  Console.ReadLine();

            Console.WriteLine("INGRESE  EL DESCUENTO DEL ESTUDINTE !");
            float descuento = float.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE  EL LEGAJO DEL ESTUDINTE !");
            uint legajo = uint.Parse(Console.ReadLine());

            CAlumno alumno1 = new CAlumno(nombre, apellido, descuento, legajo);

            Console.WriteLine(alumno1.ToString());

            Console.ReadLine();
        }
    }
}
