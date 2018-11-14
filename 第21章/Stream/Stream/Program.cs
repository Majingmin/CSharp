using System;
using System.IO;
using System.Text;

namespace Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "F:\\C#学习笔记\\第21章\\Stream\\test1.txt";
            using (FileStream fileStream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                string msg = "Hello World";
                StreamWriter streamWriter = new StreamWriter(fileStream);//创建StreamWriter对象
                //byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
                Console.WriteLine("开始写入{0}到文件", msg);
                streamWriter.Write(msg);
                //fileStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
                //fileStream.Seek(0, SeekOrigin.Begin);
                StreamReader streamReader = new StreamReader(fileStream);//创建StreamReader对象
                Console.WriteLine("写入文件中的数据为：\n{0}",streamReader.ReadToEnd());
                //byte[] byteFromFile = new byte[msgAsByteArray.Length];
                //fileStream.Read(byteFromFile, 0, msgAsByteArray.Length);
                //Console.WriteLine(Encoding.Default.GetString(byteFromFile));
                streamWriter.Close();
                streamReader.Close();
                Console.Read();
            }
        }
    }
}
