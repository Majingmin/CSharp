using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace 实现动态_ExpandoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic expand = new ExpandoObject();
            //动态绑定成员
            expand.Name = "Learning Hard";
            expand.Age = 24;
            expand.Addmethod = (Func<int, int>)(x => x + 1);
            //调用类型成员
            Console.WriteLine("expand类型的姓名为：" + expand.Name + "年龄为：" + expand.Age);
            Console.WriteLine("调用expand类型的动态绑定的方法：" + expand.Addmethod(5));
            Console.Read();
        }
    }
}
