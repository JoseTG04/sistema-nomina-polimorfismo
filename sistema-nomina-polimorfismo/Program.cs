
using sistema_nomina_polimorfismo.Clases;
class Program
{
    static void Main(string[] args)
    {
        // Crear empleados de diferentes tipos
        Empleado[] empleados = new Empleado[]
        {
            new EmpleadoAsalariado { PrimerNombre = "Juan", ApellidoPaterno = "Perez", NumeroSeguroSocial = "123456789", SalarioSemanal = 1000 },
            new EmpleadoPorHoras { PrimerNombre = "Maria", ApellidoPaterno = "Garcia", NumeroSeguroSocial = "987654321", SueldoPorHora = 15, HorasTrabajadas = 45 },
            new EmpleadoPorComision { PrimerNombre = "Pedro", ApellidoPaterno = "Lopez", NumeroSeguroSocial = "111111111", VentasBrutas = 5000, TarifaComision = 0.1 },
            new EmpleadoBaseMasComision { PrimerNombre = "Ana", ApellidoPaterno = "Martinez", NumeroSeguroSocial = "222222222", VentasBrutas = 6000, TarifaComision = 0.12, SalarioBase = 800 }
        };

        // Calcular e imprimir el ingreso de cada empleado
        foreach (Empleado empleado in empleados)
        {
            empleado.MostrarInformacion();
            Console.WriteLine("Ingreso: {0:C2}", empleado.CalcularIngreso());
            Console.WriteLine("-----------------------------");
        }
    }
}