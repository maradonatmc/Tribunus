using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TribunusAPI.Data;
using TribunusAPI.Models;
using TribunusAPI.Services;

namespace TribunusAPI.Controllers {
    [Route("API/[controller]")]
    [ApiController]
    public class TribunusController: ControllerBase {
        private readonly TribunusContext _context;
        private MembroService membroService;

        public TribunusController(TribunusContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Membro>>> GetLogin() {
            return await _context.Membro.ToListAsync();
        }

        [HttpGet("ValidarMembro/{userName}/{password}")]
        public async Task<ActionResult<Membro>> ValidarMembro(string userName, string password) {
            try {
                membroService = new MembroService(_context);
                Membro membro = await membroService.BuscarMembro(userName);

                if (membro == null) {
                    return NotFound();
                }

                return membro;
            }
            catch (Exception) {
                return NotFound();
            }
        }
    }
}
