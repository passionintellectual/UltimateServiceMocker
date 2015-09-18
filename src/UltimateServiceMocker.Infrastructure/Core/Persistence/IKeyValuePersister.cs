using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateServiceMocker.Infrastructure.Core.Persistence
{
    public interface IKeyValuePersister<TKey, TPayLoad> : IPersister<TKey, TPayLoad>
    {
    }
}
