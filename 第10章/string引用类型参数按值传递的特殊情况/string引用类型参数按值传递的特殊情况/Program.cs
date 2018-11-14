using System;

namespace string引用类型参数按值传递的特殊情况
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string引用类型参数按值传递的特殊情况");
            string str = "old string";
            RefChange(str);
            Console.WriteLine("调用方法后str的值为" + str);
            Console.Read();
        }
        public static void RefChange(string refStr)
        {
            refStr = "New String";
        }
    }
}
