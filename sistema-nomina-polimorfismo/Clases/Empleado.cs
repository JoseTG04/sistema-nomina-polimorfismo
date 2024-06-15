
namespace sistema_nomina_polimorfismo.Clases
{
    public abstract class Empleado
    {
        public string PrimerNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string NumeroSeguroSocial { get; set; }

        public abstract double CalcularIngreso();

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre completo: {0} {1}", PrimerNombre, ApellidoPaterno);
            Console.WriteLine("Número de seguro social: {0}", NumeroSeguroSocial);
        }
    }
}
