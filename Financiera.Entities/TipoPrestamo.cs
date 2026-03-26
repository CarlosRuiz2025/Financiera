namespace Financiera.Entities
{
    public class TipoPrestamo
    {
        public int ID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Tasa { get; set; }
    }
}
