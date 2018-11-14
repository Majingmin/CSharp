using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //定义投票委托
        delegate void VoteDelegate(string name);
        static void Main(string[] args)
        {
            //使用Vote方法来实例化委托对象
           // VoteDelegate votedelegate = new VoteDelegate(new Friend().Vote);
            //下面的方法为隐式实例化委托方法，他把方法直接赋给了委托对象
            VoteDelegate votedelegate =new Friend().Vote;
            //通过调用委托来回调Vote()方法,这是隐式调用方法
            votedelegate("SomeBody");
            Console.Read();
        }
        public class Friend
        {
            //朋友的投票方法
            public void Vote(string nickname)
            {
                Console.WriteLine("昵称是：{0}来帮您投票了", nickname);
            }
        }
    }
}
