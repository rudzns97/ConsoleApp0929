using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
    class StreamReader1
    {
        static void Main()
        {
            using(StreamReader sr = new StreamReader("test.log", Encoding.UTF8))
            {
                //ReadLine() 한 줄을 읽어서 string 반환
                //만약에 파일의 끝인 경우 null을 반환

                string content;
                int i = 0;
                while((content = sr.ReadLine()) != null)
                {
                    Console.WriteLine("Line {0,2} : {1}", ++i, content);
                }
                
            }
            //using (StreamReader sr = new StreamReader("test.log", Encoding.UTF8))
            //{
            //    string content = sr.ReadToEnd();
            //    Console.WriteLine(content);
            //}
            
        }
        
    }
}
