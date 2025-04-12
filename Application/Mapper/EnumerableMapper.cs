using System.Collections.Generic;
using System.Linq;

namespace OweWay.Application.Mapper
{
    public abstract class EnumerableMapper<TSource, TDestination> : IMapper<TSource, TDestination>
    {
        public abstract TDestination MapFrom(TSource source);
        public abstract TSource MapTo(TDestination destination);

        public IEnumerable<TDestination> MapFromList(IEnumerable<TSource> sourceList)
        {
            return sourceList?.Select(MapFrom).ToList();
        }

        public IEnumerable<TSource> MapToList(IEnumerable<TDestination> destinationList)
        {
            return destinationList?.Select(MapTo).ToList();
        }
    }
}
