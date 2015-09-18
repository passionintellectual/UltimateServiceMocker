using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UltimateServiceMocker.Infrastructure.Properties;

namespace UltimateServiceMocker.Infrastructure.Core.Persistence
{
    public class AppKeyValuePersister<TPayload> : IKeyValuePersister<String, TPayload>
    {
        Settings holder;
        public AppKeyValuePersister()
        {
            holder = Settings.Default;
        }
        public void Save(string key, TPayload payLoad)
        {
            PropertyInfo prop = holder.GetType().GetProperty(key, BindingFlags.Public | BindingFlags.Instance);
            if (null != prop && prop.CanWrite)
            {
                prop.SetValue(holder, key, null);
            }
        }

        public TPayload Get(string key)
        {
            PropertyInfo prop = holder.GetType().GetProperty(key, BindingFlags.Public | BindingFlags.Instance);
            if (null != prop && prop.CanRead)
            {
                return (TPayload)prop.GetValue(holder);
            }
            return default(TPayload);
        }
    }
}