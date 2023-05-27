namespace CiudadanosSanos.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Producto { get; set; }
        public ICollection<Product>? Products { get; set; } = default!;
    }
}
