namespace ClinicaSaude.ClinicaModels
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Paciente()
        {
            Nome = string.Empty; // Inicializa a propriedade Nome com uma string vazia
            Email = string.Empty; // Inicializa a propriedade Email com uma string vazia
            Telefone = string.Empty; // Inicializa a propriedade Telefone com uma string vazia
        }
    }
}