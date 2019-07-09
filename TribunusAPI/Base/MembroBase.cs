using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TribunusAPI.Context;
using TribunusAPI.Models;

namespace TribunusAPI.Base {
    public class MembroBase {
        private readonly TribunusContext _context;
        public MembroBase(TribunusContext context) {
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
