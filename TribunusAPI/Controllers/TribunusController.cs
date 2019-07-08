using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TribunusAPI.Context;
using TribunusAPI.Models;

namespace TribunusAPI.Controllers {
    [Route("WebAPI/[controller]")]
    [ApiController]
    public class TribunusController: ControllerBase {
        private readonly TribunusContext _context;

        public TribunusController(TribunusContext context) {
            _context = context;

            if (_context.Membro.Count() == 0) {
                _context.Membro.Add(new Membro {
                    SEQ_MEMBRO = 1,
                    NOME_MEMBRO = "Renato Ramos e Ramos",
                    DAT_NASCIMENTO = new DateTime(1989, 12, 20),
                    APELIDO_MEMBRO = "Maradona",
                    DAT_INGRESSO = new DateTime(2013, 06, 07),
                    SEQ_GRADUACAO = 1,
                    DSC_CNH = "AB",
                    FLG_ADAETERNUM = true,
                    FLG_ATIVO = true
                });

                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Membro>>> GetLogin() {
            return await _context.Membro.ToListAsync();
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<Membro>> ValidarLogin(int Id) {
            var membro = await _context.Membro.FindAsync(Id);

            if (membro == null) {
                return NotFound();
            }

            return membro;
        }
    }
}
