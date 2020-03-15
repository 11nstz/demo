using System.IO;
using System.Text;
using System;
 namespace duqu 
 {
    class duqu 
    {
        static void Main() 
        { 
        star : 
       try{
        Console.WriteLine("hello 郑俊豪,请输入想背的单词表，回车继续，t退出\nz转换到其他字母表");
        string url1=@".\dcb\"+Console.ReadLine()+".txt";
        StreamReader reader = new StreamReader(url1,Encoding.Unicode);
        string line ;
        bool point = true;
        Console.WriteLine("从第几个开始？");
        int star =int.Parse(Console.ReadLine())*2-1;
        int number =0;
            while((line = reader.ReadLine()) != null && point  )
              { number+=1;
                  if(number >=star)
                    {Console.WriteLine(line+" "+(number+1)/2);
                    string s=Console.ReadLine();
                      if (s =="t" ){point=false;}
                       else if (s=="z"){goto star;}
                    }
                }
        }
        catch{Console.WriteLine("存在错误，请重新输入"); goto star;}
        }
        
        
    }







 }
