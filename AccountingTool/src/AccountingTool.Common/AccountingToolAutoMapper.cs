using AutoMapper;

namespace AccountingTool.Common
{
    public class AccountingToolAutoMapper : Contracts.IMapper
    {
        private readonly IMapper _mapper;

        public AccountingToolAutoMapper()
        {
            _mapper = AutoMapperConfiguration.Configure();
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return _mapper.Map(source, destination);
        }
    }
}