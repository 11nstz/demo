using System.IO;
using System.Text;
using System;
namespace duqu
{
    class duqu
    {
        static void Main()
        {
        star:
            try
            {
                Console.WriteLine("hello 郑俊豪,请输入想背的单词表，回车继续，t退出\nz转换到其他字母表");
                string url1 = @".\dcb\" + Console.ReadLine() + ".txt";//获取字母表
                StreamReader reader = new StreamReader(url1, Encoding.Unicode);
                string line;//缓存字符
                bool point = true;//表示是否退出
                Console.WriteLine("从第几个开始？");
                int star = int.Parse(Console.ReadLine()) * 2 - 1;//换算第几个单词开始
                int number = 0;//记录当前读取位置
                while ((line = reader.ReadLine()) != null && point)
                {
                    number += 1;
                    if (number >= star)
                    {
                        Console.WriteLine(line + " " + (number + 1) / 2);//标记当前位置并输出
                        string s = Console.ReadLine();
                        if (s == "t") { point = false; }//接受退出信息
                        else if (s == "z") { goto star; }//接受换表信息
                    }
                }
            }
            catch { Console.WriteLine("存在错误，请重新输入"); goto star; }
        }


    }







}
