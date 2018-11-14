using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 合并操作符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("??运算符的使用情况如下：");
            NullcoalescingOperator();
            Console.Read();
        }
        private static void NullcoalescingOperator()
        {
            int? nullable= null;
            int? nullhasvalue = 1;
            int x = nullable ?? 12;
            int y = nullhasvalue ?? 123;
            Console.WriteLine("可空类型没有值的情况：{0}", x);
            Console.WriteLine("可空类型有值的情况："+y);

            //??用于引用类型
            Console.WriteLine();
            string stringnotnull = "123";
            string stringnull = null;
            string result = stringnotnull ?? "456";
            string result2 = stringnull ?? "12";
            Console.WriteLine("可空类型不为null的情况：{0}", result);
            Console.WriteLine("可空类型为null的情况：{0}", result2);
        }
    }
}
