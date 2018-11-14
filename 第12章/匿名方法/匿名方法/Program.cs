using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    class Program
    {
        delegate void VoteDelegate(string name);
        static void Main(string[] args)
        {
            VoteDelegate votedelegate = delegate (string nickname)
              {
                  Console.WriteLine("昵称为：{0}的朋友来投票了", nickname);
              };//匿名方法后边要加;，否则报错
            votedelegate("somebody");
            Console.Read();
        }
    }
}
