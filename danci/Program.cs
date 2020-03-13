using System.IO;
using System.Text;
using System;
 namespace duqu 
 {
    class duqu {
        static void Main() {  
        Console.WriteLine("hello 郑俊豪,请输入想背的单词表，回车继续，t退出");
        string url1=@".\dcb\"+Console.ReadLine()+".txt";
        StreamReader reader = new StreamReader(url1,Encoding.Unicode);
        string line ;
        bool point = true;
        while((line = reader.ReadLine()) != null && point)
        { Console.WriteLine(line);
        string s=Console.ReadLine();
          if (s =="t" ){point=false;}
          }
        }
        
    }







 }
