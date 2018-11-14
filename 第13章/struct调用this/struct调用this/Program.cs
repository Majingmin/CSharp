using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct调用this
{
    class Program
    {
        public struct TestPerson
        {
            public string Name { get; set; }
            public int Age { get;  set; }
            //结构体中，不显示地调用无参构造函数this（）时，会出现编译错误
            public TestPerson(string name):this()
            {
            this.Name = name;
            }
            public TestPerson(int age):this()
            {
                this.Age = age;
            }
        }
        static void Main(string[] args)
        {
            TestPerson person = new TestPerson();
            person.Name = "张飞";
            person.Age = 18;
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.Read();
        }
    }
}
