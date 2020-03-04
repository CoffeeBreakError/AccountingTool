using AccountingTool.Domain.Domain.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.Domain.Domain.Commands.Position
{
    public class CreatePositionCommand : IRequest<PositionResponse>
    {
        public string Name { get; set; }
    }
}
