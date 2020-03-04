using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AccountingTool.DAL.DTOs.Department;

namespace AccountingTool.DAL.Repositories.Contracts
{
    public interface IDepartmentRepository
    {
        Task<ICollection<DepartmentDto>> GetAll();
    }
}
