using System.Collections.Generic;

namespace OweWay.Application.Mapper
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination MapFrom(TSource source);
        TSource MapTo(TDestination destination);
        IEnumerable<TDestination> MapFromList(IEnumerable<TSource> sourceList);
        IEnumerable<TSource> MapToList(IEnumerable<TDestination> destinationList);
    }
}
