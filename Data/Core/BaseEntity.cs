namespace Sales.Data.Core
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Eliminado { get; set; }

    }
}
