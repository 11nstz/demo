
using System.
using System.IO;
using System.Text;
using System;

namespace duqu
{
    class duqu
    {
        static void Main()
        {       1.
            method m1 = new method();
            int key = 0;//判断是否循环
            while (key == 0)//建立循环
            {
                string mode = null;
                Console.WriteLine("随机还是顺序？，随机s，顺序d");
                mode = Console.ReadLine();
                switch (mode)
                {
                    case "d":
                        {
                            Console.WriteLine("hello 郑俊豪,请输入想背的单词表");
                            try
                            {
                                StreamReader reader = new StreamReader(m1.geturl(), Encoding.Unicode);
                                m1.outputword(reader, ref key);
                                reader.Close();
                            }
                            catch { Console.WriteLine("发生错误，请重新输入，注意检查"); }
                            break;
                        }
                    case "s":
                        {
                            try{
                            StreamReader reader2 = new StreamReader(@"./dcb/all.txt", Encoding.Unicode);
                            Console.WriteLine("几个？");
                            int sum = int.Parse(Console.ReadLine());
                            int[] number = new int[sum];
                            m1.creatrandom(ref number);
                            m1.outputRandomword(reader2, number, ref key);
                            reader2.Close();}
                            catch{Console.WriteLine("发生错误，请重新输入，注意检查");}
                            break;
                        }
                }
            }
        }
    }
    class method
    {   
        public string geturl()//获取单词表url
        {
            string url1 = @".\dcb\" + Console.ReadLine() + ".txt";//获取字母表
            return url1;
        }
        public void outputword(StreamReader a, ref int key)//输出固定单词表
        {
            string line;//缓存字符
            int point = 1;//表示是否退出
            Console.WriteLine("从第几个开始？");
            int star = int.Parse(Console.ReadLine()) * 2 - 1;//换算第几个单词开始
            int number = 0;//记录当前读取位置
            while ((line = a.ReadLine()) != null && point == 1)
            {
                number += 1;
                if (number >= star)
                {
                    Console.WriteLine(line + " " + (number + 1) / 2);//标记当前位置并输出
                    checkinput(ref point);
                    if (point == (int)chec.帮助)//输出操作列表
                    {
                        StreamReader r = new StreamReader(@"./help.txt", Encoding.UTF8);
                        string s = r.ReadToEnd();
                        Console.WriteLine(s);
                        point = 1;
                    }
                }
            }
            if (point == 1) { Console.WriteLine("没有这么多单词了"); }
            switch (point)
            {
                case (int)chec.跳转: break;
                case (int)chec.退出: key = 1; break;
            }
        }
        public void outputRandomword(StreamReader a, int[] shunxu, ref int key)//输出随机单词
        {
            string line;//缓存字符
            int point = 1;//表示是否退出
            int number = 0;//记录当前读取位置
            int biaohao =0;// 记录数组下标
            while ((line = a.ReadLine()) != null && point == 1 && biaohao<shunxu.Length)
            {
                number += 1;
                if ((number+1)/2 == shunxu[biaohao])
                {
                    Console.WriteLine(line + " " + (biaohao + 1));//标记当前位置并输出
                    checkinput(ref point);
                    if(point == (int)chec.继续){Console.WriteLine(a.ReadLine());number+=1;checkinput(ref point);}
                    
                    if (point == (int)chec.帮助)//输出操作列表
                    {
                        StreamReader r = new StreamReader(@"./help.txt", Encoding.UTF8);
                        string s = r.ReadToEnd();
                        Console.WriteLine(s);
                        point = 1;
                    }
                   biaohao++;
                }
            }
            if (point == 1) { Console.WriteLine("没有这么多单词了"); }
            switch (point)
            {
                case (int)chec.跳转: break;
                case (int)chec.退出: key = 1; break;
            }
        }
        public void creatrandom(ref int[] a)//创建读取的单词序号
        {   
            int leng = a.Length;
            Random r = new Random();
            for (int i = 0; i <leng; i++)
            {
                a[i] = (int)r.Next(1, 4450);
            }
            Array.Sort(a);  
        }
        void checkinput(ref int point)//检测输入操作
        {
            string s = Console.ReadLine();
            switch (s)
            {
                case "t":
                    point = (int)chec.退出;
                    break;
                case "z": point = (int)chec.跳转; break;
                case "help": point = (int)chec.帮助; break;
                default: point = (int)chec.继续; break;
            }
        }//检查输入字符并进行操作 
    }
    enum chec//操作
    {
        继续 = 1,
        退出 = 2,
        跳转 = 3,
        帮助 = 4,
    }
}

