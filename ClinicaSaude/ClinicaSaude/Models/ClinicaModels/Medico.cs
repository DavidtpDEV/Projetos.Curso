using System;

namespace ClinicaSaude.ClinicaModels
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public DateTime Horario { get; set; }

        public Medico()
        {
            Nome = string.Empty; // Inicializa a propriedade Nome com uma string vazia
            Especialidade = string.Empty; // Inicializa a propriedade Especialidade com uma string vazia
            Horario = DateTime.MinValue; // Inicializa a propriedade Horario com o valor mínimo de DateTime
        }
    }

}