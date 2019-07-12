using Microsoft.EntityFrameworkCore;
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

        public async Task<Membro> BuscarMembro(string pApelido) {
            try {
                Membro membroValido = new Membro();
                var lstMembros = _context.Membro.Where(c => c.ApelidoMembro == pApelido).ToList();

                if (lstMembros.Count == 0) {
                    return null;
                }

                foreach (Membro membro in lstMembros) {
                    membroValido = await _context.Membro.FindAsync(membro.Id);
                }

                return membroValido;
            }
            catch (Exception) {
                return null;
            }
        }

        public async Task<List<Membro>> FindAllAsync() {
            return await _context.Membro.ToListAsync();
        }

        public async Task InsertAsync(Membro obj) {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Membro> FindByIdAsync(int id) {
            return await _context.Membro.Include(obj => obj.Graduacao).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id) {
            try {
                var obj = await _context.Membro.FindAsync(id);
                _context.Membro.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException) {
                throw;
            }
        }

        public async Task UpdateAsync(Membro obj) {
            bool hasAny = await _context.Membro.AnyAsync(x => x.Id == obj.Id);

            try {
                if (hasAny) {
                    _context.Membro.Update(obj);
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateConcurrencyException e) {
                throw e;
            }
        }
    }
}
