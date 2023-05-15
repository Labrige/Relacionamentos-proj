using Relacionamentos.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Relacionamentos.Data
{
    public class RelacionamentoContext : DbContext
    {
        public RelacionamentoContext(DbContextOptions<RelacionamentoContext> options) : base(options)
        {
        }
        public DbSet<blog> ?blogs { get; set; }
        public DbSet<Post> ?posts { get; set; }

    }
}
