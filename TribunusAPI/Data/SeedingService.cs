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
            if (_context.Graduacao.Any() ||
                _context.Membro.Any() ||
                _context.Cargo.Any()) {
                return;
            }

            //Default Graduacao
            Graduacao escudado = new Graduacao("Escudado");
            Graduacao meioEscudo = new Graduacao("Meio Escudo");
            Graduacao prospero = new Graduacao("Próspero");
            _context.Graduacao.AddRange(escudado, meioEscudo, prospero);

            //Default Membro
            Membro maradona = new Membro {
                NomeMembro = "Renato Ramos e Ramos",
                DatNascimento = new DateTime(1989, 12, 20),
                ApelidoMembro = "Maradona",
                Password = "tribunus",
                DatIngresso = new DateTime(2013, 06, 07),
                Graduacao = escudado,
                DscCnh = "AB",
                FlgAdAeternum = true,
                FlgAtivo = true,
                DatUltAtualizacao = DateTime.Now
            };

            _context.Membro.AddRange(maradona);

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
