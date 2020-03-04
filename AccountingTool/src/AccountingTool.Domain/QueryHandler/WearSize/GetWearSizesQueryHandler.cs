using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountingTool.Common.Contracts;
using AccountingTool.DAL.DTOs.WearSize;
using AccountingTool.DAL.Repositories.Contracts;
using AccountingTool.Domain.Domain.Models.WearSizeResponse;
using AccountingTool.Domain.Domain.Queries.WearSize;
using MediatR;

namespace AccountingTool.Domain.QueryHandler.WearSize
{
    public class GetWearSizesQueryHandler : IRequestHandler<GetWearSizesQuery, ICollection<WearSizeResponse>>
    {
        private readonly IWearSizeRepository _wearSizeRepository;
        private readonly IMapper _mapper;

        public GetWearSizesQueryHandler(IWearSizeRepository wearSizeRepository, IMapper mapper)
        {
            _wearSizeRepository = wearSizeRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<WearSizeResponse>> Handle(GetWearSizesQuery request, CancellationToken cancellationToken)
        {
            var wearSizes = await _wearSizeRepository.GetAll();
            var res = _mapper.Map<ICollection<WearSizeDto>, ICollection<WearSizeResponse>>(wearSizes);

            return res;
        }
    }
}
