using System.Threading.Tasks;
using Aerolinea.Vuelos.Domain.Interfaces;
using Aerolinea.Vuelos.Infrastructure.EF.Contexts;

namespace Aerolinea.Vuelos.Infrastructure.EF {
    public class UnitOfWork : IUnitOfWork {
        private readonly WriteDbContext _context;

        public UnitOfWork(WriteDbContext context) {
            _context = context;
        }
        public async Task Commit() {
            await _context.SaveChangesAsync();
        }
    }
}
