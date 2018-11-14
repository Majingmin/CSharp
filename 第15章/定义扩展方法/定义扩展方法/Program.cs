using System.Collections.Generic;
using System;

namespace 定义扩展方法
{
    class Program
    {
        //调用扩展方法
        static void Main(string[] args)
        {
            List<int> source = new List<int>() { 1, 2, 3, 4, 5,6,3 };
            //计算数组中小标为奇数的所有项之和
            //int jsum = ListExten.JSum(source);
            //另一种调用方法
            int jsum = source.JSum();
            Console.WriteLine("数组的奇数和为：" + jsum);
            Console.Read();
        }
    }
    //扩展方法必须在非泛型静态类中定义
    public static class ListExten
    {
        //定义扩展方法
        public static int JSum(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("输入数组为空");
            }
            int jsum = 0;
            //flag变量用作下标，以计算所以奇数下标项之和
            bool flag = false;
            foreach (int current in source)
            {
                if (!flag)
                {
                    jsum += current;
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return jsum;
        }
    }
}
