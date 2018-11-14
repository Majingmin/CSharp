using System;
using System.Threading;
using System.Diagnostics;

namespace 锁的使用对性能造成的影响
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            const int iterationNumber = 5000000;
            Stopwatch sw = Stopwatch.StartNew();
            for(int i=0;i<iterationNumber;i++)
            {
                x++;
            }
            Console.WriteLine("不使用锁的情况下花费的时间：{0}ms", sw.ElapsedMilliseconds);
            sw.Restart();
            for (int i = 0; i < iterationNumber; i++)
            {
                Interlocked.Increment(ref x);
            }
            Console.WriteLine("使用锁的情况下花费的时间：{0}ms", sw.ElapsedMilliseconds);
            Console.Read();
        }
    }
}
