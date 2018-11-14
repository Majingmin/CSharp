using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 使用Linq_to_XML查询
{
    class Program
    {
        //初始化XML数据
        private static string xmlString =
            "<Persons>" +
            "<Person Id='1'>" +
            "<Name>张三</Name>" +
            "<Age>18</Age>" +
            "</Person>" +
            "<Person Id='2'>" +
            "<Name>李四</Name>" +
            "<Age>19</Age>" +
            "</Person>" +
            "<Person Id='3'>" +
            "<Name>王五</Name>" +
            "<Age>22</Age>" +
            "</Person>" +
            "</Persons>";
        static void Main(string[] args)
        {
            Console.WriteLine("使用Linq来对XML文件查询，查询结果为：");
            OldLinqToXMLQuery();
            Console.Read();
        }
        private static void OldLinqToXMLQuery()
        {
            //导入XML文件
            XElement xmlDoc = XElement.Parse(xmlString);
            //创建查询，获取姓名为“李四”的元素
            var queryResult = from element in xmlDoc.Elements("Person")
                              where element.Element("Name").Value == "李四"
                              select element;
           
                //输出查询结果
            foreach(var xele in queryResult)
            {
                Console.WriteLine("姓名为：" + xele.Element("Name").Value + "Id为：" + xele.Attribute("Id").Value);
            }
                
            }
        }
}
