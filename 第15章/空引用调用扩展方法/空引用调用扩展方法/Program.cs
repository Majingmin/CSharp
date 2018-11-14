using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 空引用调用扩展方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("空引用上调用扩展方法演示：");
            string s = null;
            Console.WriteLine("字符串S为空字符串：{0}", s.IsNull());
            Console.Read();
        }
    }
    public static class NullExten
    {
        //不规范的定义扩展方法的方式                                                          
        public static bool IsNull(this object obj)
        {
            return obj != null;
        }
    }
}
