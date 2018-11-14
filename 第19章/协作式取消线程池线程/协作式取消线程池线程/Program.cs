using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace 协作式取消线程池线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程运行");
            CancellationTokenSource cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(callback, cts.Token);
            Console.WriteLine("按下回车键以取消");
            Console.Read();
            cts.Cancel();
            Console.ReadKey();
        }
        private static void callback(object state)
        {
            CancellationToken token = (CancellationToken)state;
            Console.WriteLine("开始计数");
            Count(token, 100);
        }
        private static void Count(CancellationToken token,int countto)
        {
            for(int i=0;i<countto;i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("计数取消");
                    return;
                }
                Console.WriteLine("计数为：" + i);
                Thread.Sleep(30);
            }   
            Console.WriteLine("计数完成");
            
        }
    }
}
