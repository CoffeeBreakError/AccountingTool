using AccountingTool.Common;
using AccountingTool.DAL.DTOs;
using AccountingTool.Domain.Domain.Commands.Position;
using AccountingTool.Domain.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

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
