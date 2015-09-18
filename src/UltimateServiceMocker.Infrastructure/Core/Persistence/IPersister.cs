using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateServiceMocker.Infrastructure.Core.Persistence
{
    public interface IPersister<TKey, TPayLoad>
    {
        void Save(TKey key, TPayLoad payLoad);
        TPayLoad Get(TKey key);
    }
}
