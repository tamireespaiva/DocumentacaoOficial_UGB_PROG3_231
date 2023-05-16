using Microsoft.EntityFrameworkCore;
using Relacionamentos.Models;
using System.Collections.Generic;

namespace Relacionamentos.Data
{
    public class RelacionamentoContext : DbContext
    {
            public RelacionamentoContext(DbContextOptions<RelacionamentoContext> options) : base(options)
            {
            }
            public DbSet<Blog> Instituicoes { get; set; }
            public DbSet<Post> Departamento { get; set; }


        }
    }
