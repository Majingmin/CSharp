using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentNamespace
{
    //要使用不同命名空间的扩展方法，要先引入该命名空间
    using CustomNamespace;
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Learning hard" };
            p.Print();
            p.Print("Hello");
            Console.Read();
        }
    }
    //自定义类型
    public class Person
    {
        public string Name { get; set; }
    }
    //当前命名空间下的扩展方法
    public static class Extensionclass
    {
        //扩展方法定义
        public static void Print(this Person per)
        {
            Console.WriteLine("调用的是当前命名空间下的扩展方法输出，姓名为：{0}", per.Name);
        }
    }
    public static class Extensionclass2
    {
        //扩展方法定义
        public static void Print(this Person per)
        {
            Console.WriteLine("调用的是当前命名空间下的扩展方法输出，姓名为：{0}", per.Name);
        }
    }
}
namespace CustomNamespace
{
    using CurrentNamespace;
    public static class CustomExtensionClass
    {
        //扩展方法定义
        public static void Print(this Person per)
        {
            Console.WriteLine("调用的是CustomNamespace命名空间下扩展方法输出，姓名为：{0}" , per.Name);
        }
        //扩展方法定义
        public static void Print(this Person per,string s)
        {
            Console.WriteLine("调用的是CustomNamespace命名空间下扩展方法输出，姓名为:{0},附加字符串为{1}", per.Name, s);
        }
    }
}
