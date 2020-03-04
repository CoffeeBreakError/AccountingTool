using AccountingTool.Common.Contracts;
using AccountingTool.DAL.DTOs.Position;
using AccountingTool.DAL.EF.Context;
using AccountingTool.DAL.Models.Entities;
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
        private readonly IMapper _mapper;

        public PositionRepository(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PositionDto> Add(PositionCreationDto position)
        {
            var positionToAdd = _mapper.Map<PositionCreationDto, Position>(position);

            await _context.Positions.AddAsync(positionToAdd);
            await _context.SaveChangesAsync();

            var res = _mapper.Map<Position, PositionDto>(positionToAdd);

            return res;
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
