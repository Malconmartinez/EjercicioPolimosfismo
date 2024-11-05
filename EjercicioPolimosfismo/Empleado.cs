using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimosfismo
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public virtual decimal CalcularSalario()
        {
            return 3000;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {Nombre}");
            Console.WriteLine($"Salario: {CalcularSalario()}");
        }
    }
}
