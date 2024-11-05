using System;
namespace EjercicioPolimosfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado { Nombre = "Malcon"};
            Empleado gerente = new Gerente { Nombre = "Alexander" };
            Empleado desarrollador = new Desarrollador { Nombre = "Pedro" };

            empleado.MostrarInformacion();
            Console.WriteLine();

            gerente.MostrarInformacion();
            Console.WriteLine();

            desarrollador.MostrarInformacion();
            Console.WriteLine();    
        }
    }
}
