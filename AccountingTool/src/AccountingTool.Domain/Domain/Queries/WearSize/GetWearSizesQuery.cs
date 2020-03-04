using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.Domain.Domain.Models.WearSizeResponse;
using MediatR;

namespace AccountingTool.Domain.Domain.Queries.WearSize
{
    public class GetWearSizesQuery : IRequest<ICollection<WearSizeResponse>>
    {
    }
}
