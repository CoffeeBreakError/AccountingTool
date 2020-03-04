using AccountingTool.DAL.DTOs.Position;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccountingTool.DAL.Repositories.Contracts
{
    public interface IPositionRepository
    {
        Task<ICollection<PositionDto>> GetAll();
        Task<PositionDto> Add(PositionCreationDto position);
    }
}
