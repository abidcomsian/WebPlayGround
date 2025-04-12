using System.Collections.Generic;

namespace OweWay.Domain.Contracts
{
    public interface IMapTo<TDestination>
    {
        TDestination MapTo();
    }

}
