using System;
using System.Collections;

namespace 迭代器
{
    class Program
    {
        static void Main(string[] args)
        {
            Friends friendcollection = new Friends();
            foreach(Friend f in friendcollection)
            {
                Console.WriteLine(f.Name);
            }
            Console.Read();
        }
        //朋友类
        public class Friend
        {
            //private string name;
            public string Name { get; set;}
            public Friend(string name)
            {
                this.Name = name;
            }
        }
        //朋友集合
        public class Friends:IEnumerable
        {
            private Friend[] friendarray;
            public Friends()
            {
                friendarray = new Friend[]
                {
                    new Friend("张飞"),
                    new Friend("李四"),
                    new Friend("王五")
                };
            }
            //索引器
            public Friend this[int index]
            {
                get { return friendarray[index]; }
            }
            public int Count
            {
                get { return friendarray.Length; }
            }
            //C#2.0简化了迭代器的实现
            public IEnumerator GetEnumerator()
            {
                 for(int index=0;index<friendarray.Length;index++)
                {
                    //在C#2.0中，只需要使用下面语句就可以实现一个迭代器
                    yield return friendarray[index];
                }
            }
        }
    }
}
