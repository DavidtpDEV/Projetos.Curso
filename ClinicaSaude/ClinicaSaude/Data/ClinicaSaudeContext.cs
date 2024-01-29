using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinicaSaude.ClinicaModels;

namespace ClinicaSaude.Data
{
    public class ClinicaSaudeContext : DbContext
    {
        public ClinicaSaudeContext (DbContextOptions<ClinicaSaudeContext> options)
            : base(options)
        {
        }

        public DbSet<ClinicaSaude.ClinicaModels.Medico> Medico { get; set; } = default!;

        public DbSet<ClinicaSaude.ClinicaModels.Paciente> Paciente { get; set; } = default!;
    }
}
