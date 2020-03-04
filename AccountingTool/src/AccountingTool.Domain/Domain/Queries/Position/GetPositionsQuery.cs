using AccountingTool.Domain.Domain.Models.Position;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.Domain.Domain.Queries.Position
{
    public class GetPositionsQuery : IRequest<ICollection<PositionResponse>>
    {
    }
}
