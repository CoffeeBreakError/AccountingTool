using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingTool.DAL.DTOs.Department;
using AccountingTool.DAL.EF.Context;
using AccountingTool.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AccountingTool.DAL.Repositories.Implementation
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<DepartmentDto>> GetAll()
        {
            var query = _context.Departments
                .Select(d => new DepartmentDto()
                {
                    Id = d.Id,
                    Name = d.Name
                });

            var departments = await query.ToListAsync();

            return departments;
        }
    }
}
