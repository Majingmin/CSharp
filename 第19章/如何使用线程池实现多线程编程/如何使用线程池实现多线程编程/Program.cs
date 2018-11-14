using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace 如何使用线程池实现多线程编程
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程ID={0}", Thread.CurrentThread.ManagedThreadId);
            ThreadPool.QueueUserWorkItem(CallBackWorkItem);
            ThreadPool.QueueUserWorkItem(CallBackWorkItem,"work");
            Thread.Sleep(3000);
            Console.WriteLine("从主线程退出");
        }
        private static void CallBackWorkItem(object state)
        {
            Console.WriteLine("线程池线程开始执行");
            if(state!=null)
            {
                Console.WriteLine("线程池线程ID={0} 传入的参数为:{1}", Thread.CurrentThread.ManagedThreadId, state.ToString());
            }
            else
            {
                Console.WriteLine("线程池线程ID={0}", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
