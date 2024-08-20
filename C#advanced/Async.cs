using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced
{
    public class Async
    {
        public async Task asyncDemo()
        {
            Console.WriteLine("Working...");

            // Giả lập một công việc dài 2 giây
            await Task.Delay(2000);

            Console.WriteLine("Work completed");
        }
    }
}

