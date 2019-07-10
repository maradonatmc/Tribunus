using Microsoft.EntityFrameworkCore;
using TribunusAPI.Models;

namespace TribunusAPI.Data {
    public class TribunusContext : DbContext {
        public TribunusContext(DbContextOptions<TribunusContext> options) : base(options) {
        }

        public DbSet<Membro> Membro { get; set; }
        public DbSet<Graduacao> Graduacao { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Diretoria> Diretoria { get; set; }
        public DbSet<Moto> Moto { get; set; }
        public DbSet<MotoMembro> MotoMembro { get; set; }
        public DbSet<Reuniao> Reuniao { get; set; }
        public DbSet<Ata> Ata { get; set; }
        public DbSet<AtaReuniao> AtaReuniao { get; set; }
    }
}
