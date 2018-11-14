using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型静态字段及静态函数问题
{
    //泛型类型，具有一个类型参数
    public static class TypeWithStaticfiled<T>
    {
        //静态字段
        public static string field;
        //静态构造函数
        public static void OutFiled()
        {
            Console.WriteLine(field + ":" + typeof(T).Name);
        }
    }
    //非泛型类型
    public static class NoGenericTypeWithStaticfiled
    {
        //静态字段
        public static string field;
        //静态构造函数
        public static void OutFiled()
        {
            Console.WriteLine(field);
        }
    }
    public static class GenericClass<T>
    {
        static GenericClass()
        {
            Console.WriteLine("泛型的构造函数被调用了，实际类型为：" + typeof(T));
        }
        public static void Print()
        {
        }
    }
    public static class NonGenericClass
    {
        static NonGenericClass()
        {
            Console.WriteLine("非泛型的构造函数被调用了");
        }
        public static void Print()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //使用不同的类型实参来实例化泛型类型
            TypeWithStaticfiled<int>.field = "一";
            TypeWithStaticfiled<string>.field = "二";
            TypeWithStaticfiled<Guid>.field = "三";
            //对于非泛型类型，此时field只有一个值，每次赋值都改变原来的值
            NoGenericTypeWithStaticfiled.field = "非泛型类静态字段一";
            NoGenericTypeWithStaticfiled.field = "非泛型类静态字段二";
            NoGenericTypeWithStaticfiled.field = "非泛型类静态字段三";
            //NoGenericTypeWithStaticfiled.OutFiled();
            //证明每一个封闭类型都有一个静态字段
            TypeWithStaticfiled<int>.OutFiled();
            TypeWithStaticfiled<string>.OutFiled();
            TypeWithStaticfiled<Guid>.OutFiled();
            NoGenericTypeWithStaticfiled.OutFiled();
            //每个泛型类型都会调用自己的静态构造函数
            GenericClass<int>.Print();
            GenericClass<string>.Print();
            //对于非泛型类型，其构造函数只能被调用一次
            NonGenericClass.Print();
            NonGenericClass.Print();
            Console.Read();
        }
    }
}
