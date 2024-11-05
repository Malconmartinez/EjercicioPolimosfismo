using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimosfismo
{
    public class Desarrollador : Empleado
    {
        public override decimal CalcularSalario()
        {
            return base.CalcularSalario() + 1000;
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Gerente: {Nombre}");
            Console.WriteLine($"Salario: {CalcularSalario()}");
        }
    }
}
