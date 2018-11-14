using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用Linq_to_Object查询集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArray = new List<int>();
            for(int i=1;i<100;i++)
            {
                inputArray.Add(i);
            }
            Console.WriteLine("使用Linq方法来对集合对象查询，查询结果为：");
            LinqQuery(inputArray);
            Console.Read();
        }
        private static void LinqQuery(List<int> collection)
        {
            //创建查询表达式来获得集合中为偶数的元素
            var queryResult = from item in collection
                              where item % 2 == 0
                              where item % 3 == 0
                              select item;
            //输出查询结果
            foreach(var item in queryResult)
            {
                Console.Write(item + " ");
            }
        }
    }
}
