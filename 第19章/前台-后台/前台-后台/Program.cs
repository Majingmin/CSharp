using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace 前台_后台
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread backThread = new Thread(Worker);//创建一个线程
            backThread.IsBackground = true;
            backThread.Start();
            //Thread.Sleep(5000);
           // backThread.Join();
            Console.WriteLine("从主线程中退出");
           //Console.ReadKey();
        }
        public static void Worker()
        {
            //Thread.Sleep(3000);
            Console.WriteLine("从后台线程退出");
            //Console.Read();
        }
    }
}
