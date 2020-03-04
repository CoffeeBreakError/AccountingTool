using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.DTOs.Department;
using AccountingTool.Domain.Domain.Models.Department;
using MediatR;

namespace AccountingTool.Domain.Domain.Queries.Departments
{
    public class GetDepartmentsQuery : IRequest<ICollection<DepartmentResponse>>
    {
    }
}
