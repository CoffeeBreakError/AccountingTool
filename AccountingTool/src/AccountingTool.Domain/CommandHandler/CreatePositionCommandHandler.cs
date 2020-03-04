using AccountingTool.Common.Contracts;
using AccountingTool.DAL.DTOs;
using AccountingTool.DAL.Models.Entities;
using AccountingTool.DAL.Repositories.Contracts;
using AccountingTool.Domain.Domain.Commands.Position;
using AccountingTool.Domain.Domain.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AccountingTool.Domain.CommandHandler
{
    public class CreatePositionCommandHandler : IRequestHandler<CreatePositionCommand, PositionResponse>
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;

        public CreatePositionCommandHandler(IPositionRepository positionRepository,
            IMapper mapper)
        {
            _positionRepository = positionRepository;
            _mapper = mapper;
        }

        public async Task<PositionResponse> Handle(CreatePositionCommand request, CancellationToken cancellationToken)
        {
            PositionCreationDto position = _mapper.Map<CreatePositionCommand, PositionCreationDto>(request);

            var addedPosition = await _positionRepository.Add(position);

            var res = _mapper.Map<PositionDto, PositionResponse>(addedPosition);

            return res;
        }
    }
}
