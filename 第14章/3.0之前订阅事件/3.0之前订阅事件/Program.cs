using System;
using System.Windows.Forms;//加入额外的命名空间

namespace _3._0之前订阅事件
{
    class Program
    {
        static void Main(string[] args)
        {
            //新建一个button实例
            Button button1 = new Button() { Text="Click"};//对象初始化器
            //button1.Text = "点击我";
            //C#2.0中使用匿名方法来订阅事件
            //button1.Click += delegate (object sender, EventArgs e)
             // {
             //     ReportEvent("Click事件", sender, e);
             // };
            //button1.KeyPress += delegate (object sender, KeyPressEventArgs e)
             // {
              //    ReportEvent("KeyPress事件，即键盘按下事件", sender, e);
            //  };
            //C#3.0采用Lambda表达式来订阅事件
            button1.Click+=(sender,e)=>ReportEvent("Click事件",sender,e);
            button1.KeyPress += (sender, e) => ReportEvent("KeyPres事件", sender, e);
            //C#3.0中使用对象初始化器
            Form form = new Form { Name = "在控制台中创建的窗体", AutoSize = true, Controls = { button1 } };
            //C#3.0之前，初始化对象时会使用以下代码
            //Form form = new Form();
            //form.Name = "在控制台中创建的窗体";
            //form.AutoSize = true;
            //form.Controls.Add(button1);
            //运行窗体
            Application.Run(form);
        }
        //记录事件的回调方法
        private static void ReportEvent(string title,object sender,EventArgs e)
        {
            Console.WriteLine("发生的事件为：{0}", title);
            Console.WriteLine("发生事件的对象为：{0}", sender);
            Console.WriteLine("发生事件参数为：{0}", e.GetType());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
