using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型封闭还是开放
{
    public class DictionaryStringKey<T> : Dictionary<string, T>
    {
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //Dictionary<,>是一个开放类型，他有两个类型参数
            Type t = typeof(Dictionary<,>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);
            //DictionaryStringKey<>也是一个开放类型，但他只有一个类型参数
            t = typeof(DictionaryStringKey<>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);
            //DictionaryStringKey<int>也是一个封闭类型
            t = typeof(DictionaryStringKey<int>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);
            //Dictionary<int，int>也是一个封闭类型
            t = typeof(Dictionary<int,int>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);
            Console.Read();
        }
    }
}
