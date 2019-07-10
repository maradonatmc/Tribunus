using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TribunusAPI.Data;
using TribunusAPI.Models;

namespace TribunusAPI.Services {
    public class MembroService {
        private readonly TribunusContext _context;
        public MembroService(TribunusContext context) {
            _context = context;
        }

        public List<Membro> BuscarMembro(string pApelido) {
            try {
                var membro = _context.Membro.Where(c => c.APELIDO_MEMBRO == pApelido).ToList();

                if (membro == null) {
                    return null;
                }

                return membro;
            }
            catch (Exception ex) {
                return null;
            }
        }
    }
}
