using System.Collections.Generic;

namespace ControleAutomoveis.Models
{
    public class Proprietario
    {
        public int ProprietarioId { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public ICollection<Veiculo>? Veiculos { get; set; }
    }
}