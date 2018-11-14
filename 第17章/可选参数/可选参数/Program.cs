using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可选参数
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod(2, 4, "Hello");
            TestMethod(2, 4);
            TestMethod(2);
            TestMethod(2, name: "Hello");
            Console.Read();
        }
        static void TestMethod(int x,int y=10,string name="Learning Hard")
        {
            Console.WriteLine("x={0} y={1} name={2}", x, y, name);
            //Console.Read();
        }
    }
}
