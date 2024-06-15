
namespace sistema_nomina_polimorfismo.Clases
{
    public class EmpleadoAsalariado : Empleado
    {
        public double SalarioSemanal { get; set; }

        public override double CalcularIngreso()
        {
            return SalarioSemanal;
        }
    }
}
