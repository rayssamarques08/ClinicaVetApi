using System.Text.Json.Serialization;

namespace ClinicaVetApi.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Motivo { get; set; }
        public int ProfessorId { get; set; }

        public int PetId { get; set; }
        [JsonIgnore]
        public int VeterinarioId { get; set; }
        [JsonIgnore]


    }
}
