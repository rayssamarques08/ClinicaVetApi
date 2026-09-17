namespace ClinicaVetApi.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRMV { get; set; }
        public string Especialidade { get; set; }

        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();


    }


}
