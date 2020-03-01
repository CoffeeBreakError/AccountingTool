using AccountingTool.Common;
using AccountingTool.DAL.DTOs;
using AccountingTool.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Mapper
{
    class PositionAutoMapperProfile : AutoMapperProfile
    {
        public PositionAutoMapperProfile()
        {
            CreateMap<PositionDto, Position>();
            CreateMap<PositionCreationDto, Position>();

            CreateMap<Position, PositionDto>();
        }
    }
}
