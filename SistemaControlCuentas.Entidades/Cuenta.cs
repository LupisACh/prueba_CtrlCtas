namespace SistemaControlCuentas.Entidades
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public string NombreCuetna { get; set; }
        public string Alias { get; set; }
        public string Descripcion { get; set; }
        public double MontoTotal { get; set; }
        public double MontoEjercido { get; set; }
        public string EjercicioFiscal { get; set; }
        public short Activa { get; set; }
        public short IdDepartamento { get; set; }
    }
}
