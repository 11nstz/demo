using System;
using System.IO;
using System.Text;


namespace danci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello 郑俊豪，按t退出，回车继续");
            Program ruko = new Program();
            ruko.duqu();
            
        }
        private void duqu()
        {    string url3= Console.ReadLine();
             string url1 =@"D:\vscode\c#\danci\dcb\";
            string url2 = ".txt";
            url1=url1+url3+url2;
            StreamReader reader = new StreamReader(url1,Encoding.Unicode);
            string line;
            int flag1=0;
            while((line=reader.ReadLine())!=null && flag1==0)
            {Console.WriteLine(line);
            string tuichu =Console.ReadLine();
             if(tuichu=="t"){flag1=1;}}
             }
      
    }
}
