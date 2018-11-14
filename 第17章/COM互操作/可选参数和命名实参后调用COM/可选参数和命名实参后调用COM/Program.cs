using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace 可选参数和命名实参后调用COM
{
    class Program
    {
        static void Main(string[] args)
        {
            //启用word并使word可见
            Application wordApp = new Application() { Visible = true };
            //新建word文档
            wordApp.Documents.Add();
            Document wordDoc = wordApp.ActiveDocument;
            Paragraph para = wordDoc.Paragraphs.Add();
            para.Range.Text = "欢迎你，进入Learning Hard博客园";
            //保存文档
            object filename = @"F:\C#学习笔记\第17章\COM互操作\learning hard.doc";
            //使用命名参数使得代码更加易懂
            wordDoc.SaveAs(FileName:filename);
            //关闭word
            wordDoc.Close();
            wordApp.Application.Quit();
        }
    }
}
