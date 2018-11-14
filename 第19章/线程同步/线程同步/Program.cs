using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace 线程同步
{
    class Program
    {
        static int ticket = 100;
        static object gloalObj = new object();//辅助对象
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(SaleTicketThread1);
            Thread thread2 = new Thread(SaleTicketThread2);
            thread1.Start();
            thread2.Start();
            //Thread.Sleep(4000);
        }
        private static void SaleTicketThread1()
        {
            while (true)
            {
                //try
                //{
                    Monitor.Enter(gloalObj);//在object对象上获得排他锁
                    Thread.Sleep(1);
                    if (ticket > 0)
                        Console.WriteLine("线程1出票:" + ticket--);
                    else
                        break;
                //}
                //finally
                //{
                   Monitor.Exit(gloalObj);//释放指定对象上的排他锁
                //}
            }
        }
        private static void SaleTicketThread2()
        {
            while (true)
            {
                //try
                //{
                    Monitor.Enter(gloalObj);//在object对象上获得排他锁
                    Thread.Sleep(1);
                    if (ticket > 0)
                        Console.WriteLine("线程2出票:" + ticket--);
                    else
                        break;
               // }
                //finally
               // {
                    Monitor.Exit(gloalObj);//释放指定对象上的排他锁
               // }
            }
        }
    }
}
