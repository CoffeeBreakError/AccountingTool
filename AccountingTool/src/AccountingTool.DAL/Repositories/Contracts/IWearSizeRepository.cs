using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AccountingTool.DAL.DTOs.WearSize;
using AccountingTool.DAL.EF.Context;

namespace AccountingTool.DAL.Repositories.Contracts
{
    public interface IWearSizeRepository
    {
        Task<ICollection<WearSizeDto>> GetAll();
    }
}
