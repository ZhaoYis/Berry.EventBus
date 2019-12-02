using EventBus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Test
{
    /// <summary>
    /// 功能描述    ：TestEventData  
    /// 创 建 者    ：赵轶
    /// 创建日期    ：2019-12-02 11:22:36 
    /// 最后修改者  ：赵轶
    /// 最后修改日期：2019-12-02 11:22:36 
    /// </summary>
    public class TestEventData : EventData
    {
        public string Message { get; set; }
    }
}
