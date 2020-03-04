using AccountingTool.Common;
using AccountingTool.Common.Contracts;
using AccountingTool.DAL.DTOs;
using AccountingTool.DAL.Repositories.Contracts;
using AccountingTool.Domain.Domain.Queries.Position;
using AccountingTool.Domain.QueryHandler;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace AccountingTool.Domain.Tests.Positions.Handlers
{
    public class GetPositionsQueryHandlerTests
    {
        private readonly IMapper _mapper;

        public GetPositionsQueryHandlerTests()
        {
            _mapper = new AccountingToolAutoMapper();
        }

        [Fact]
        public async void Should_Returns_MappedPositions()
        {
            var expected = new List<PositionDto>()
            {
                new PositionDto() { Id = Guid.NewGuid(), Name = "first" },
                new PositionDto() { Id = Guid.NewGuid(), Name = "second" },
                new PositionDto() { Id = Guid.NewGuid(), Name = "third" }
            };
            var mock = new Mock<IPositionRepository>();
            mock.Setup(p => p.GetAll())
                .ReturnsAsync(expected);

            var query = new GetPositionsQueryHandler(mock.Object, _mapper);
            var actual = await query.Handle(new GetPositionsQuery(), new CancellationToken());

            Assert.Equal(expected.Count, actual.Count);
        }
    }
}
