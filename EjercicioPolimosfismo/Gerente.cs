

namespace EjercicioPolimosfismo
{
    public class Gerente : Empleado
    {
        public override decimal CalcularSalario()
        {
            return base.CalcularSalario();
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Gerente: {Nombre}");
            Console.WriteLine($"Salario: {CalcularSalario()}");
        }
    }
}
