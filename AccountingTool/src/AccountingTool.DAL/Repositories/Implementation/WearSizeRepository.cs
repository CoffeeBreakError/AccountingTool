using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingTool.DAL.DTOs.WearSize;
using AccountingTool.DAL.EF.Context;
using AccountingTool.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AccountingTool.DAL.Repositories.Implementation
{
    public class WearSizeRepository : IWearSizeRepository
    {
        private readonly ApplicationDbContext _context;

        public WearSizeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<WearSizeDto>> GetAll()
        {
            var query = _context.WearSizes
                .Select(w => new WearSizeDto()
                {
                    Id = w.Id,
                    Size = w.Size
                });

            var wearSizes = await query.ToListAsync();

            return wearSizes;
        }
    }
}
