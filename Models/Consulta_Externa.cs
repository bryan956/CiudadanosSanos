namespace CiudadanosSanos.Models
{
    public class Consulta_Externa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Consulta_Externa> Consulta_Externas { get; set; }
    }
}
