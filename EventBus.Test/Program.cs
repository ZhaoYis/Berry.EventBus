using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEventData eventData = new TestEventData
            {
                Message = "测试EventBus"
            };
            EventBus.Core.EventBus.Default.Trigger<TestEventData>(eventData);

            Console.ReadKey();
        }
    }
}
