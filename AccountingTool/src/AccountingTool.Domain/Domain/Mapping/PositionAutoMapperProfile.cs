using AccountingTool.Common;
using AccountingTool.DAL.DTOs.Position;
using AccountingTool.Domain.Domain.Commands.Position;
using AccountingTool.Domain.Domain.Models.Position;

namespace AccountingTool.Domain.Domain.Mapping
{
    public class PositionAutoMapperProfile : AutoMapperProfile
    {
        public PositionAutoMapperProfile()
        {
            CreateMap<PositionDto, PositionResponse>();

            CreateMap<CreatePositionCommand, PositionCreationDto>();
        }
    }
}
