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
        Console.WriteLine("从第几个开始？");
        int star =(int)Console.Read()*2-1;
        int number =0;
        while((line = reader.ReadLine()) != null && point  )
        { number+=1;
        if(number >=star)
               {Console.WriteLine(line);
                string s=Console.ReadLine();
                if (s =="t" ){point=false;}
               }
          }
        }
        
    }







 }
