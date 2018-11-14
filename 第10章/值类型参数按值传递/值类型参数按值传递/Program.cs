using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型参数按值传递
{
    class Program
    {
        static void Main(string[] args)
        {
            int addNum = 1;
            //addNum就是实参
            Add(addNum);
        }
        //addnum就是形参，即被调用方法中的参数
        private static void Add(int addnum)
        {
            addnum = addnum + 1;
            Console.WriteLine(addnum);
            Console.Read();
        }
    }
}
