using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OweWay.Domain.Contracts
{
    public interface IMapFrom<TSource>
    {
        void MapFrom(TSource source);
    }
}
