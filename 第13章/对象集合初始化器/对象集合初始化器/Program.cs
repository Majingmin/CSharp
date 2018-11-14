using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对象集合初始化器
{
    class Program
    {
        static void Main(string[] args)
        {
            //没有对象初始化器时的代码
            //Person p = new Person("LearningHard", 25);
            //p.Weight = 60;
            //p.Height = 170;
            //对象集合初始化器
            Person p = new Person("") { Name = "LearningHard", Age = 25, Height = 170, Weight = 60 };
            //与上边代码等价，只不过下面省略了构造函数的圆括号
            Person p2 = new Person{ Name = "LearningHard", Age = 25 };
            Console.WriteLine("姓名："+p.Name+"\n年龄："+p.Age+"\n身高："+p.Height + "\n体重：" + p.Weight);
            Console.WriteLine("姓名：" + p2.Name + "\n年龄：" + p2.Age + "\n身高：" + p2.Height + "\n体重：" + p2.Weight);
            Console.Read();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set;}
        public int Height { get; set; }
        //自定义有参构造函数，覆盖默认的无参构造函数
        public Person(string name)
        {
            this.Name = name;
        }
        //此时需自定义无参构造函数，否则会出错
        public Person()
        { }
        //定义不同情况下的初始化函数
        //下面均为未使用对象集合初始化器时的代码
        //public Person():this("")
        //{ }
        //public Person(string name) : this(name, 0)
        //{ }
       // public Person(string name,int age):this(name,age,0)
        //{
        //    this.Name = name;
       //     this.Age = age;
        //}
       // public Person(string name, int age,int weight) : this(name, age,weight, 0)
        //{ }
        //public Person(string name, int age, int weight,int height)
       // {
        //    this.Name = name;
        //    this.Age = age;
         //   this.Weight = weight;
         //   this.Height = height;
       // }
    }
}
