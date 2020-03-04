using AccountingTool.Common.Contracts;
using AccountingTool.DAL.DTOs;
using AccountingTool.DAL.Repositories.Contracts;
using AccountingTool.Domain.Domain.Queries.Position;
using AccountingTool.Domain.Domain.Responses;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AccountingTool.Domain.QueryHandler
{
    public class GetPositionsQueryHandler : IRequestHandler<GetPositionsQuery, ICollection<PositionResponse>>
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;

        public GetPositionsQueryHandler(IPositionRepository positionRepository,
            IMapper mapper)
        {
            _positionRepository = positionRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<PositionResponse>> Handle(GetPositionsQuery request, CancellationToken cancellationToken)
        {
            var positions = await _positionRepository.GetAll();
            var res = _mapper.Map<ICollection<PositionDto>, ICollection<PositionResponse>>(positions);

            return res;
        }

        public void Test()
        {

        }
    }
}
