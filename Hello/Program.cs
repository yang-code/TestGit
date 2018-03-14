using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    /// <summary>
    /// 测试 git123
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 100000000; i++)
            {

            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedTicks);
        }
    }
}
