using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结婚Lambda
{
    class Program
    {
        public class Bridegroom
        {
            //自定义委托
            public delegate void MarryHandler(string msg);
            //使用自定义委托定义事件
            public event MarryHandler MarryEvent;
            //发出事件
            public void OnMarriageComing(string msg)
            {
                if (MarryEvent != null)
                {
                    //触发事件
                    MarryEvent(msg);
                }
            }
            static void Main(string[] args)
            {
                //初始化新郎官对象
                Bridegroom bridegroom = new Bridegroom();
                //{Console.WriteLine("朋友们，我要结婚了，要准时参加婚礼哦")};
                //实例化朋友对象
                Friend friend1 = new Friend("张三");
                Friend friend2 = new Friend("李四");
                Friend friend3 = new Friend("王五");
                //使用+=来订阅事件
                bridegroom.MarryEvent += new MarryHandler(friend1.SendMessage);
                bridegroom.MarryEvent += new MarryHandler(friend2.SendMessage);
                //发出通知，此时只有订阅事件的对象才能收到通知
                bridegroom.OnMarriageComing("盆友们，我要结婚了，到时候大家准时参加婚礼哦");
                Console.WriteLine("-----------------------------------------------");
                //使用-=来退订事件
                bridegroom.MarryEvent -= new MarryHandler(friend2.SendMessage);
                //使用+=来订阅事件
                bridegroom.MarryEvent -= new MarryHandler(friend3.SendMessage);
                //发出通知
                bridegroom.OnMarriageComing("盆友们，我要结婚了，到时候大家准时参加婚礼哦");
                Console.Read();
            }
        }
        public class Friend
        {
            //字段
            public string Name;
            //构造函数
            public Friend(string name)
            {
                this.Name = name;
            }
            public void SendMessage(string message)
            {
                Console.WriteLine(message);
                Console.WriteLine(this.Name + "收到了，准时参加的");
            }
        }
    }
}
