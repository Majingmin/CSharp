using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型的按引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            string oldstring = "mjm";
            ChangeValue(ref num);
            Console.WriteLine("调用方法后值类型" + num);
            ChangeRef(ref oldstring);
            Console.WriteLine("调用方法后引用类型" + oldstring);
            Console.Read();
        }
        public static void ChangeValue(ref int newnum)
        {
            newnum = 2;
            Console.WriteLine(newnum);
        }
        public static void ChangeRef(ref string newstring)
        {
            newstring = "majingmin";
            Console.WriteLine(newstring);
        }
    }
}
