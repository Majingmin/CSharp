using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法如何延长变量的生命周期
{
    class Program
    {
        delegate void ClosureDelegate();
        static void Main(string[] args)
        {
            ClosureDelegate test = CreateDelegateInstance();
            //此时会回调匿名方法，输出count值
            test();
            Console.Read();
        }
        //闭包延长生命的周期
        private static ClosureDelegate CreateDelegateInstance()
        {
            //外部变量
            int count = 1;
            int count1 = 10;
            Console.WriteLine(count1);
            //使用匿名方法来实例化委托对象
            ClosureDelegate closureDelegate = delegate
              {
                  //int count1 = 10;
                  //Console.WriteLine(count1);
                  count++;
                  Console.WriteLine(count);
              };
            //调用委托来回调匿名方法
            closureDelegate();
            return closureDelegate;
        }
    }
}
//编译器会额外创建一个类来容纳被捕捉的变量，此时count变量会被分配在堆上。CreateDelegateInstance方法有该类的一个实例引用
//所以此时匿名方法捕捉到的是变量count的一个引用，而不是真真的值。在这个过程中，匿名方法延长了变量count的生命周期
//使它感觉不再是一个局部变量，而是一个全局变量了