using System;
using System.Linq.Expressions;
namespace 通过Lambda表达式来构造表达式树
{
    class Program
    {
        static void Main(string[] args)
        {
            //将Lambda表达式构造成表达式树
            Expression<Func<int,int,int>> expressionTree=(a,b)=>a + b;
            //通过调用Compile方法来生成Lambda表达式的委托
            Func<int, int, int> delinstance = expressionTree.Compile();
            //调用委托实例获得结果
            int result = delinstance(2, 3);
            Console.WriteLine("2和3的和为：" + result);
            //Console.Read();
            //获得表达式参数
            Console.WriteLine("参数1：{0},参数2：{1}", expressionTree.Parameters[0], expressionTree.Parameters[1]);
            BinaryExpression body = (BinaryExpression)expressionTree.Body;
            //左节点，每个节点本身就是一个表达式对象
            ParameterExpression left = (ParameterExpression)body.Left;
            //右节点
            ParameterExpression right = (ParameterExpression)body.Right;
            //输出表达式树结构
            Console.WriteLine("表达式树结构为：" + expressionTree);
            //输出
            Console.WriteLine("表达式树主体为：");
            Console.WriteLine(expressionTree.Body);
            Console.WriteLine("表达式树左节点为：{0}{4} 节点类型为：{1}{4}{4} 表达式右节点为：{2}{4} 节点类型为：{3}{4}",
                left.Name, left.Type, right.Name, right.Type, Environment.NewLine);
            Console.Read();
        }
    }
}
