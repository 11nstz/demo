using System;
using System.Net;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest HttpWReq =
            (HttpWebRequest)WebRequest.Create("https://www.zhihu.com/");
            //获得响应
            HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
            Stream dataStream = HttpWResp.GetResponseStream();
            StreamReader streamReader = new StreamReader(dataStream, Encoding.UTF8);
            string s = @"\bS\S*";
            foreach (Match match in Regex.Matches(streamReader.ReadToEnd(), s))
                {   
                    Console.WriteLine(match.Value);
                }
            Console.ReadKey();
        }
    }
}

