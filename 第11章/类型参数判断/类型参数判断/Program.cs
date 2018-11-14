using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型参数判断
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 2;
            //不使用类型推断的代码
            //genericMethod<int>(ref n1,ref n2);
            //使用类型推断
            genericMethod(ref n1, ref n2);
            Console.WriteLine("n1现在的值为：" + n1);
            Console.WriteLine("n2现在的值为：" + n2);
            string str1 = "123";
            string str2 = "456";
            //使用类型推断时可能出现的编译错误
            genericMethod(ref str1,ref str2);
            Console.WriteLine("str1现在为：" + str1);
            Console.WriteLine("str2现在为：" + str2);
            Console.Read();
        }
        private static void genericMethod<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }
    }
}
