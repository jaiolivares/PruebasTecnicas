namespace CrudBlazor.Shared.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }
        public bool Actual { get; set; }
    }
}