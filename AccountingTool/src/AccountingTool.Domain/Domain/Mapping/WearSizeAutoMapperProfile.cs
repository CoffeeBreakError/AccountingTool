using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.Common;
using AccountingTool.DAL.DTOs.WearSize;
using AccountingTool.Domain.Domain.Models.WearSizeResponse;

namespace AccountingTool.Domain.Domain.Mapping
{
    public class WearSizeAutoMapperProfile : AutoMapperProfile
    {
        public WearSizeAutoMapperProfile()
        {
            CreateMap<WearSizeDto, WearSizeResponse>();
        }
    }
}
