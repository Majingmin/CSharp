using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 引用类型参数的按值传递
{
    public class RefClass
    {
        public int addNum;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //引用类型按值传递的情况
            Console.WriteLine("引用类型按值传递的情况");
            RefClass refClass = new RefClass();
            refClass.addNum = 1;
            //refClass是实参，此时参数是引用类型
            AddRef(refClass);
            Console.WriteLine("调用方法后，实参addNum的值：" + refClass.addNum);
            Console.Read();
        }
        //引用类型按值传递的情况，addnumRef为形参
        private static void AddRef(RefClass addnumRef)
        {
            addnumRef.addNum += 1;
            Console.WriteLine("方法中addNum的值：" + addnumRef.addNum);
        }
    }
}
