using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Loja_de_Carros.Models;

namespace Loja_de_Carros.Data
{
    public class Loja_de_CarrosContext : DbContext
    {
        public Loja_de_CarrosContext (DbContextOptions<Loja_de_CarrosContext> options)
            : base(options)
        {
        }

        public DbSet<Loja_de_Carros.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<Loja_de_Carros.Models.Carro>? Carro { get; set; }

        public DbSet<Loja_de_Carros.Models.Vendedor>? Vendedor { get; set; }

        public DbSet<Loja_de_Carros.Models.Nota>? Nota { get; set; }
    }
}
