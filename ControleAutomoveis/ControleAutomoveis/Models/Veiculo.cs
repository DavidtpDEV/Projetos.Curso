namespace ControleAutomoveis.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Placa { get; set; }
        public int Ano { get; set; }
        public int ProprietarioId { get; set; }
        public Proprietario? Proprietario { get; set; }
    }
}