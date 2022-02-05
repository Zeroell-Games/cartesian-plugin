using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartesian.EditMode.Plugin
{
    public interface IChart
    {
        int Version { get; }
        void OnChartLoad(ICtsEvent property);
        void OnNoteLoad(ICollection<ICtsEvent> events);
        void OnTimingLoad(ICollection<ICtsEvent> events);

    }
}
