using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 隐式类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //用var声明局部变量
            var stringvariable = "learning hard";
            //stringvariable = 2;//报错说明变量为静态变量
            //优点：使用隐式类型就不需要在赋值的左右两侧都指定Dictionary<string,string>了
            var dictionary = new Dictionary<string, string>();
            //缺点：
            var a = 244981564186453;
            var b = 01234567889;
            var c = 156435153152312;
            Console.WriteLine("变量a的类型为：{0}",a.GetType());
            Console.WriteLine("变量a的类型为：{0}", b.GetType());
            Console.WriteLine("变量a的类型为：{0}", c.GetType());
            Console.Read();
        }
    }
}
