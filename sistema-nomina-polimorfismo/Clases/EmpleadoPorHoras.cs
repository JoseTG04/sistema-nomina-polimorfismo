
namespace sistema_nomina_polimorfismo.Clases
{
    public class EmpleadoPorHoras : Empleado
    {
        public double SueldoPorHora { get; set; }
        public double HorasTrabajadas { get; set; }

        public override double CalcularIngreso()
        {
            double pagoRegular = SueldoPorHora * HorasTrabajadas;
            double pagoExtra = 0;

            if (HorasTrabajadas > 40)
            {
                pagoExtra = (HorasTrabajadas - 40) * SueldoPorHora * 1.5;
            }

            return pagoRegular + pagoExtra;
        }
    }
}
