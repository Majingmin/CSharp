using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda表达式的演变
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda表达式的演变过程
            //下面是C#1.0中创建委托实例的代码
            //Func<string, int> delegatetest1 = new Func<string, int>(Callbackmethod);
            //
            //C#2.0中用匿名方法来创建委托实例，此时不需要额外定义回调方法Callbackmethod了
           // Func<string, int> delegatetest2 = delegate (string test)
               // {
                //    return test.Length;
                //};
            //
            //C#3.0中使用Lambda表达式来创建委托实例
            Func<string, int> delegatetest3 = (string test) => test.Length;
            //可以省略类型参数string，将代码进一步简化
            Func<string, int> delegatetest4 = (test) => test.Length;
            //可以将圆括号去掉
            Func<string, int> delegatetest = test => test.Length;
            //调用委托
            Console.WriteLine("使用Lamnda表达式返回字符串的长度为：" + delegatetest("learning hard"));
            Console.Read();
        }
        //回调方法
        //private static int Callbackmethod(string text)
        //{
         //   return text.Length;
       // }
    }
}
