using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合初始化器
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#3.0之前初始化集合所用的代码
            List<string> names = new List<string>();
                names.Add("Learning hard1");
                names.Add("Learning hard2");
                names.Add("Learning hard3");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("第{0}个人名字是：{1}",i+1 ,names[i]);
            }
            //使用集合初始化器
            List<int> ages = new List<int>()
            {
                10,12,14,16,18,20
            };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("第{0}个人年龄是：{1}", i + 1, ages[i]);
            }
            Console.Read();
        }
    }
}
