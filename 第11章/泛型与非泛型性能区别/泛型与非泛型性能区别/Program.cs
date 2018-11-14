using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型与非泛型性能区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试泛型类型的运行时间
            testGeneric();
            //测试非泛型类型的运行时间
            testNonGeneric();
            Console.Read();
        }
        public static void testGeneric()
        {
            //Stopwatch对象用来测量运行时间
            Stopwatch stopwatch = new Stopwatch();
            //泛型数组
            List<int> genericlist = new List<int>();
            //开始计时
            stopwatch.Start();
            //循环一千次来比较运行时间
            for (int i = 1; i < 10000000; i++)
            {
                genericlist.Add(i);
            }
            //结束计时
            stopwatch.Stop();
            //输出所用时间
            TimeSpan ts = stopwatch.Elapsed;
            //使时间以00：00：00这样的格式输出
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("泛型类型运行时间：" + elapsedTime);
        }
        public static void testNonGeneric()
        {
            //Stopwatch对象用来测量运行时间
            Stopwatch stopwatch = new Stopwatch();
            //非泛型数组
            ArrayList arraylist = new ArrayList();
            //开始计时
            stopwatch.Start();
            //循环一千次来比较运行时间
            for (int i = 1; i < 10000000; i++)
            {
                arraylist.Add(i);
            }
            //结束计时
            stopwatch.Stop();
            //输出所用时间
            TimeSpan ts = stopwatch.Elapsed;
            //使时间以00：00：00这样的格式输出
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("非泛型类型运行时间：" + elapsedTime);
        }
    }
}
