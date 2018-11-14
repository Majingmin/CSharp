using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 闭包_匿名方法中捕捉了外部变量_
{
    class Program
    {
        delegate void ClosureDelegate();
        static void Main(string[] args)
        {
            //调用方法
            closureMethod();
            Console.Read();
        }
        //闭包方法
        private static void closureMethod()
        {
            //outVariable及capturedVariable对于匿名方法而言都是外部变量
            string outVariable = "外部变量";
            //而capturedVariable是被匿名方法捕捉的外部变量
            string capturedVariable = "被捕获的外部变量";
            ClosureDelegate closuredelegate = delegate
              {
                //localVariable匿名方法中的局部变量
                string localVariable = "匿名方法局部变量";
                //捕捉外部变量capturedVariable
                Console.WriteLine(capturedVariable + "\n" + localVariable);
              };
            //调用委托
            closuredelegate();
        }
    }
}
