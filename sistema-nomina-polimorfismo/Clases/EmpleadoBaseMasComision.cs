

namespace sistema_nomina_polimorfismo.Clases
{
    public class EmpleadoBaseMasComision : Empleado
    {
        public double VentasBrutas { get; set; }
        public double TarifaComision { get; set; }
        public double SalarioBase { get; set; }

        public override double CalcularIngreso()
        {
            double comision = VentasBrutas * TarifaComision;
            double ingresoTotal = comision + SalarioBase;

            // Recompensa para empleados asalariados por comisión
            if (this is EmpleadoBaseMasComision comisionado)
            {
                ingresoTotal += SalarioBase * 0.1;
            }

            return ingresoTotal;
        }
    }
}
