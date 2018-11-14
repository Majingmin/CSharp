using System;
using System.IO;

namespace Directory_and_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "F:\\C#学习笔记\\第21章\\Directory and DirectoryInfo\\DirectorySample";
            string filePath = string.Format("{0}\\{1}", dirPath, "test.txt");
            FileStream fs = null;
            StreamWriter writer = null;
            if(!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
                Console.WriteLine("创建一个目录：{0}", dirPath);
            }
            else
            {
                Console.WriteLine("目录{0}已存在", dirPath);
            }
            FileInfo file = new FileInfo(filePath);
            if(!file.Exists)
            {
                fs=File.Create(filePath);
                Console.WriteLine("创建一个文件：{0}", filePath);
            }
            else
            {
                fs = File.Open(filePath, FileMode.Open);
                Console.WriteLine("文件：{0}已存在", filePath);
            }
            writer = new StreamWriter(fs);
            writer.WriteLine("测试文本");
            Console.WriteLine("向文件写入数据");
            writer.Flush();
            writer.Close();
            fs.Close();
            Console.WriteLine("关闭数据流");
        }
    }
}
