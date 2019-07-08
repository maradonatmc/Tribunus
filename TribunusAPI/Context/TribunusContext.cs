using Microsoft.EntityFrameworkCore;
using TribunusAPI.Models;

namespace TribunusAPI.Context {
    public class TribunusContext : DbContext {
        public TribunusContext(DbContextOptions<TribunusContext> options) : base(options) {
        }

        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Diretoria> Diretoria { get; set; }
        public DbSet<Graduacao> Graduacao { get; set; }
        public DbSet<Membro> Membro { get; set; }
    }
}
