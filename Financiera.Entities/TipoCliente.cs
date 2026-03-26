namespace Financiera.Entities
{
    public class TipoCliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Activo { get; set; }
    }
}
