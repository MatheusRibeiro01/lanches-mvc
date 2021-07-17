using System.Collections.Generic;
using System.Linq;
using Lanches.Context;
using Lanches.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p =>
            p.IsLanchePreferido).Include(c => c.categoria);
        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}