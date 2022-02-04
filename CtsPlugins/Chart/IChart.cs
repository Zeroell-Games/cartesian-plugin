using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartesian.EditMode.Plugin
{
    public interface IChart
    {
        /// <summary>
        /// 判断是否更新谱面
        /// </summary>
        /// <param name="version"></param>
        /// <returns>upgraded</returns>
        bool OnChartLoad(int version);
        void OnNoteLoad(ICollection<ICtsEvent> events);
        void OnTimingLoad(ICollection<ICtsEvent> events);

    }
}
