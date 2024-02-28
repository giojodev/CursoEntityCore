namespace CursoEntityCore.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Categoria { get; set; }
        public string Descripcion { get; set; }
    }
}
