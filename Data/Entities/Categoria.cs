using Sales.Data.Core;

namespace Sales.Data.Entities
{
    public class Categoria : BaseEntity
    {
        public string? Descripcion { get; set; }
        public bool EsActivo { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public DateTime? FechaMod { get; set; }
        public int? IdUsuarioMod { get; set; }
        public int? IdUsuarioElimino { get; set; }
        public DateTime? FechaElimino { get; set; }
    }
}
