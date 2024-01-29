using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleAutomoveis.Models;

namespace ControleAutomoveis.Data
{
    public class ControleAutomoveisContext : DbContext
    {
        public ControleAutomoveisContext (DbContextOptions<ControleAutomoveisContext> options)
            : base(options)
        {
        }

        public DbSet<ControleAutomoveis.Models.Proprietario> Proprietario { get; set; } = default!;
        public DbSet<ControleAutomoveis.Models.Veiculo> Veiculo { get; set; } = default!;
    }
}
