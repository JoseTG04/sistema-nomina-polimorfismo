

namespace sistema_nomina_polimorfismo.Clases
{
    public class EmpleadoPorComision : Empleado
    {
        public double VentasBrutas { get; set; }
        public double TarifaComision { get; set; }

        public override double CalcularIngreso()
        {
            return VentasBrutas * TarifaComision;
        }
    }
}
