using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.Common;
using AccountingTool.DAL.DTOs.Department;
using AccountingTool.Domain.Domain.Models.Department;

namespace AccountingTool.Domain.Domain.Mapping
{
    public class DepartmentAutoMapperProfile : AutoMapperProfile
    {
        public DepartmentAutoMapperProfile()
        {
            CreateMap<DepartmentDto, DepartmentResponse>();
        }
    }
}
