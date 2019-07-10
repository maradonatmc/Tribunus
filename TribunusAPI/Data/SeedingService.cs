using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TribunusAPI.Models;

namespace TribunusAPI.Data {
    public class SeedingService {
        private TribunusContext _context;

        public SeedingService(TribunusContext context) {
            _context = context;
        }

        public void Seed() {
            if (_context.Membro.Any() ||
                _context.Graduacao.Any() ||
                _context.Cargo.Any()) {
                return;
            }

            //Default Membro

            _context.Membro.AddRange();

            //Default Graduacao
            Graduacao g1 = new Graduacao("Escudado");
            Graduacao g2 = new Graduacao("Meio Escudo");
            Graduacao g3 = new Graduacao("Próspero");
            _context.Graduacao.AddRange(g1, g2, g3);

            //Default Cargo
            Cargo c1 = new Cargo("Presidente");
            Cargo c2 = new Cargo("Vice-Presidente");
            Cargo c3 = new Cargo("Diretor Financeiro");
            Cargo c4 = new Cargo("Diretor Conduta");
            Cargo c5 = new Cargo("Diretor Social");
            Cargo c6 = new Cargo("Diretor Secretário");
            Cargo c7 = new Cargo("Sgt Armas");
            Cargo c8 = new Cargo("Conselheiro");
            _context.Cargo.AddRange(c1, c2, c3, c4, c5, c6, c7, c8);

            _context.SaveChanges();
        }
    }
}
