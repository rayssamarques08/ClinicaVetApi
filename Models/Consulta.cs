using System.Text.Json.Serialization;

namespace ClinicaVetApi.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Motivo { get; set; }
        public int PetId { get; set; }
        public int VeterinarioId { get; set; }
        [JsonIgnore]
        public Veterinario? Veterinario { get; set; }
        public Pet? Pet { get; set; }

    }
}
