using AccountingTool.Domain.Domain.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.Domain.Domain.Queries
{
    public class GetPositionsQuery : IRequest<ICollection<PositionResponse>>
    {
    }
}
