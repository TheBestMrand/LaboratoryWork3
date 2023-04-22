using LaboratoryWork3.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryWork3.Models.Services
{
    public class ResidentService
    {
        private readonly AppDbContext _context;

        public ResidentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Resident>> GetResidentsAsync()
        {
            return await _context.Residents.Include(r => r.Payments).ToListAsync();
        }
    }
}
