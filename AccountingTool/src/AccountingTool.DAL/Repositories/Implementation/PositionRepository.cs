using AccountingTool.Common.Contracts;
using AccountingTool.DAL.DTOs;
using AccountingTool.DAL.EF.Context;
using AccountingTool.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingTool.DAL.Repositories.Implementation
{
    public class PositionRepository : IPositionRepository
    {
        private readonly ApplicationDbContext _context;

        public PositionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<PositionDto>> GetAll()
        {
            var query = _context.Positions
                .Select(p => new PositionDto
                {
                    Id = p.Id,
                    Name = p.Name
                });

            var positions = await query.ToListAsync();

            return positions;
        }
    }
}
