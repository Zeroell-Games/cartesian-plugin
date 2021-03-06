using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartesian.EditMode.Plugin
{
    public interface ICtsEvent
    {
        bool GetProperty<T>(string key, out T value);
        void SetProperty<T>(string key, T value);
        void RemoveProperty(string key);
    }
}
