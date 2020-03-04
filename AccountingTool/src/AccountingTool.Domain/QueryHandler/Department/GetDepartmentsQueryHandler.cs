using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountingTool.Common.Contracts;
using AccountingTool.DAL.DTOs.Department;
using AccountingTool.DAL.Repositories.Contracts;
using AccountingTool.Domain.Domain.Models.Department;
using AccountingTool.Domain.Domain.Queries.Departments;
using MediatR;

namespace AccountingTool.Domain.QueryHandler.Department
{
    public class GetDepartmentsQueryHandler : IRequestHandler<GetDepartmentsQuery, ICollection<DepartmentResponse>>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public GetDepartmentsQueryHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<DepartmentResponse>> Handle(GetDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var departments = await _departmentRepository.GetAll();
            var res = _mapper.Map<ICollection<DepartmentDto>, ICollection<DepartmentResponse>>(departments);

            return res;
        }
    }
}
