using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可空类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //下面的代码也可以这样子定义int? value=1
            Nullable<int> value = 1;
            Console.WriteLine("可空类型有值的输出情况：");
            Display(value);
            Console.WriteLine();
            Console.WriteLine();
            value = new Nullable<int>();
            Console.WriteLine("可空类型没有值时的输出情况：");
            Display(value);
            Console.Read();
        }
        //输出方法，演示可空类型中的方法和属性使用
        private static void Display(int? nullable)
        {
            //HasValue属性指示可空对象是否有值
            Console.WriteLine("可空类型是否有值：{0}", nullable.HasValue);
            if(nullable.HasValue)
            {
                Console.WriteLine("值为：{0}", nullable.Value);
            }
            //GetValueOrDefault(代表如果可空对象有值，就用它的值返回，如果可空对象不包含值，则返回默认值0)
            //相当于下面语句
            //if(!nullable.HasValue)
            //{
            //    result = d.Value;
            //}
            Console.WriteLine("GetValueOrDefault():{0}", nullable.GetValueOrDefault());
            //GetValueOrDefault(T)方法代表如果HasValue属性为true，则为Value属性的值；
            //否则为defaultValue参数值，即为2
            Console.WriteLine("GetValueOrDefault重载方法使用：{0}", nullable.GetValueOrDefault(10));
            //GetHasCode()代表如果HasValue属性为true，则为Value属性返回对象的哈希代码
            //如果HasValue属性为false，则为零
            Console.WriteLine("GetHasCode()方法的使用：{0}", nullable.GetHashCode());
        }
    }
}
