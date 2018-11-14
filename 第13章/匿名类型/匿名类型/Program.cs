using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义匿名类型对象
            var person = new { Name = "LearningHard", Age = 25 };
            Console.WriteLine("{0}的年龄为：{1}", person.Name, person.Age);
            //定义匿名类型数组
            var personcollection = new[]
            {
                new {Name="Tom",Age=2},
                new {Name="Tony",Age=10},
                new {Name="Tenny",Age=20},
                //加入下面一行代码会出现编译错误，此时编译器不能推断出要转化为什么类型
                //new {Name="Learning hard"}
            };
            int totalAge = 0;
            foreach(var p in personcollection)
            {
                //下面一行代码证明了Age属性是强类型的int类型
                totalAge += p.Age;
            }
            Console.WriteLine("所有人的年龄总和为：{0}", totalAge);
            Console.Read();
        }
    }
}
